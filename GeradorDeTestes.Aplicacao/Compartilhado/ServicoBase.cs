using FluentResults;
using FluentValidation;
using Microsoft.Data.SqlClient;
using Serilog;


namespace GeradorDeTestes.Aplicacao.Compartilhado
{
    public abstract class ServicoBase<T> where T : EntidadeBase<T>
    {
        public IRepositorio<T> repositorio;
        public AbstractValidator<T> validador;

        public ServicoBase(IRepositorio<T> repositorio, AbstractValidator<T> validador)
        {
            this.repositorio = repositorio;
            this.validador = validador;
        }


        public Result Inserir(T entidade)
        {
            Log.Debug("Tentando inserir entidade...{@e}",entidade);

            List<string> erros = ValidarEntidade(entidade);
          
            if (erros.Count > 0)
                return Result.Fail(erros);

            try
            {
                object id = repositorio.Inserir(entidade);
                Log.Debug("Entidade {EntidadeId} inserida com sucesso", id);
            }
            catch (SqlException exc)
            {
                string msgErro = "Falha ao tentar inserir entidade";

                Log.Error(exc, msgErro + "{@e}", entidade);

                return Result.Fail(msgErro);
            }
                
            return Result.Ok();
        }


        public Result Atualizar(T entidade)
        {
            Log.Debug("Tentando atualizar entidade...{@e}", entidade);

            List<string> erros = ValidarEntidade(entidade);

            if (erros.Count > 0)
                return Result.Fail(erros);

            try
            {
                repositorio.Atualizar(entidade.id, entidade);
                Log.Debug("Entidade {EntidadeId} atualizada com sucesso", entidade.id);
            }
            catch (SqlException exc)
            {
                string msgErro = "Falha ao tentar atualizar entidade";

                Log.Error(exc, msgErro + "{e}", entidade);

                return Result.Fail(msgErro);
            }


            return Result.Ok();
        }


        public virtual Result Deletar(T entidade)
        {
            List<string> erros = new();
            Log.Debug("Tentando deletar entidade...{@e}", entidade);

            try
            {
                repositorio.Deletar(entidade.id);
                Log.Debug("Entidade {EntidadeId} deletada com sucesso", entidade.id);
                return Result.Ok();
                
            }
            catch (SqlException exc)
            {
                string msgErro = "Falha ao tentar deletar entidade";

                Log.Error(exc, msgErro + "{e}", entidade);

                return Result.Fail(msgErro);
            }
        }

        public List<string> ValidarEntidade(T entidade)
        {
            List<string> erros = validador.Validate(entidade)
               .Errors.Select(x => x.ErrorMessage).ToList();

            if (EntidadeDuplicada(entidade))
                erros.Add($"'{entidade.ToString()}' já está sendo utilizado na aplicação");

            foreach (string erro in erros)
            {
                Log.Warning(erro);
            }

            return erros;          

        }


        protected abstract bool EntidadeDuplicada(T entidade);



        
    }
}
