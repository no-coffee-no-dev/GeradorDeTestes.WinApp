using FluentResults;
using GeradorDeTestes.Aplicacao.Compartilhado;
using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloQuestao;
using GeradorDeTestes.Dominio.ModuloTeste;
using Microsoft.Data.SqlClient;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Aplicacao.ModuloTeste
{
    public class ServicoTeste : ServicoBase<Teste>
    {
        IRepositorioQuestao repositorioQuestao;
        IRepositorioTeste repositorioTeste;
        ValidadorTeste validadorTeste;
        public ServicoTeste(IRepositorioTeste repositorioTeste, IRepositorioQuestao repositorioQuestao,ValidadorTeste validadorTeste) : base(repositorioTeste,validadorTeste)
        {
            this.repositorioTeste = repositorioTeste;
            this.repositorioQuestao = repositorioQuestao;
            this.validadorTeste = validadorTeste;
        }

        public Result Inserir(Teste teste)
        {
            Log.Debug("Tentando inserir Teste...{@t}", teste);

            List<string> erros = ValidarEntidade(teste);

            if (erros.Count > 0)
                return Result.Fail(erros);

            try
            {
                repositorioTeste.Inserir(teste, teste.listaQuestoes);
                Log.Debug("Teste {TesteId} inserido com sucesso", teste.id);
            }
            catch(SqlException exc)
            {
                string msgErro = "Falha ao tentar inserir teste.";

                Log.Error(exc, msgErro + "{t}", teste);

                return Result.Fail(msgErro);
            }

            return Result.Ok();
        }

        protected override bool EntidadeDuplicada(Teste teste)
        {
            List<Teste> testes = repositorioTeste.RetornarTestesPorTitulo(teste);
            if (testes.Exists(q => q.titulo == teste.titulo && q.id != teste.id))
                return true;

            return false;
        }

    }
}
