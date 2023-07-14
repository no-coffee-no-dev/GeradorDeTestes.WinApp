using FluentResults;
using GeradorDeTestes.Aplicacao.Compartilhado;
using GeradorDeTestes.Dominio.ModuloQuestao;
using GeradorDeTestes.Dominio.ModuloTeste;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Aplicacao.ModuloTeste
{
    public class ServicoTeste : ServicoBase<Teste>
    {
        IRepositorioTeste repositorioTeste;
        public ServicoTeste(IRepositorioTeste repositorioTeste) : base(repositorioTeste)
        {
            this.repositorioTeste = repositorioTeste;
        }

        public Result Inserir(Teste teste)
        {
            List<string> erros = ValidarEntidade(teste);

            if (erros.Count > 0)
                return Result.Fail(erros);

            repositorioTeste.Inserir(teste,teste.listaQuestoes);

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
