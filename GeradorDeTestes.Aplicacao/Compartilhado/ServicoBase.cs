using FluentResults;
using GeradorDeTestes.Dominio.ModuloDisciplina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Aplicacao.Compartilhado
{
    public abstract class ServicoBase<T> where T : EntidadeBase<T>
    {
        public IRepositorio<T> repositorio;

        public ServicoBase(IRepositorio<T> repositorio)
        {
            this.repositorio = repositorio;
        }


        public Result Inserir(T entidade)
        {
            List<string> erros = ValidarEntidade(entidade);

            if (erros.Count > 0)
                return Result.Fail(erros);

            repositorio.Inserir(entidade);
                
            return Result.Ok();
        }


        public Result Atualizar(T entidade)
        {

            List<string> erros = ValidarEntidade(entidade);

            if (erros.Count > 0)
                return Result.Fail(erros);

            repositorio.Atualizar(entidade.id,entidade);


            return Result.Ok();
        }


        public virtual Result Deletar(T entidade)
        {
            List<string> erros = new();

            try
            {
                repositorio.Deletar(entidade.id);
                return Result.Ok();
            }
            catch (Exception ex)
            {

            }

            
            return Result.Ok();
        }

        public List<string> ValidarEntidade(T entidade)
        {
            List<string> erros = new List<string>(entidade.Validar());

            if (EntidadeDuplicada(entidade))
                erros.Add($"'{entidade.ToString()}' já está sendo utilizado na aplicação");

            return erros;
        }


        protected abstract bool EntidadeDuplicada(T entidade);



        
    }
}
