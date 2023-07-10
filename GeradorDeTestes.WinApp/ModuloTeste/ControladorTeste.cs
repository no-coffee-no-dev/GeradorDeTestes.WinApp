using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.Dominio.ModuloQuestao;
using GeradorDeTestes.Dominio.ModuloTeste;
using GeradorDeTestes.WinApp.ModuloQuestao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.WinApp.ModuloTeste
{
    public class ControladorTeste : ControladorBase
    {
        private IRepositorioTeste repositorioTeste;
        private IRepositorioQuestao repositorioQuestao;
        private IRepositorioMateria repositorioMateria;
        private IRepositorioDisciplina repositorioDisciplina;
        private TabelaTesteControl tabelaTestes;

        public ControladorTeste(IRepositorioQuestao repositorioQuestao, IRepositorioMateria repositorioMateria, IRepositorioDisciplina repositorioDisciplina, IRepositorioTeste repositorioTeste)
        {
            this.repositorioTeste = repositorioTeste;
            this.repositorioQuestao = repositorioQuestao;
            this.repositorioMateria = repositorioMateria;
            this.repositorioDisciplina = repositorioDisciplina;
        }

        public override string ToolTipInserir => "Inserir um novo Teste";

        public override string ToolTipEditar => "Editar um Teste Existente";

        public override string ToolTipExcluir => "Excluir um Teste Existente";

        public override bool BotaoInserirAtivado => true;

        public override bool BotaoDeletarAtivado => true;

        public override bool BotaoEditarAtivado => true;

        public override bool BotaoVisualizarItensAtivado => false;

        public override bool BotaoConfigurarDescontoAtivado => false;

        public override void CarregarEntidades()
        {
            List<Teste> testes = repositorioTeste.RetornarTodos();
            tabelaTestes.AtualizarRegistros(testes);
        }

        public override void Deletar()
        {
            throw new NotImplementedException();
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Inserir()
        {
            TelaTesteForm telaTeste = new TelaTesteForm(repositorioMateria,repositorioDisciplina,repositorioQuestao);

            DialogResult opcaoEscolhida = telaTeste.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Teste teste = telaTeste.Teste;
                List<Questao> listaQuestoes = telaTeste.ListaQuestoes;
                repositorioTeste.Inserir(teste, listaQuestoes);

                CarregarEntidades();
            }
        }

        public override UserControl ObterListagem()
        {
            if (tabelaTestes == null)
                tabelaTestes = new TabelaTesteControl();

            CarregarEntidades();

            return tabelaTestes;
        }

        public override string ObterTipoCadastro()
        {
           return "Cadastros de Teste";
        }
    }
}
