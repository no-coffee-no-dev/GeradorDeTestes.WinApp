using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.Dominio.ModuloQuestao;
using GeradorDeTestes.Dominio.ModuloTeste;
using GeradorDeTestes.WinApp.ModuloQuestao;
using System;
using System.Collections.Generic;
using System.Configuration;
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

        public override bool BotaoVisualizarItensAtivado => true;

        public override bool BotaoGerarPDFAtivado => true;

        public override bool BotaoDuplicarTesteAtivado => true;

        public override void CarregarEntidades()
        {
            List<Teste> testes = repositorioTeste.RetornarTodos();
            tabelaTestes.AtualizarRegistros(testes);
        }

        public override void Deletar()
        {

            Teste teste = ObterTesteSelecionado();

            if (teste == null)
            {
                MessageBox.Show($"Selecione uma Teste primeiro!",
                    "Exclusão de Testes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a Teste {teste.titulo}?", "Exclusão de Testes",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioTeste.Deletar(teste.id);

                CarregarEntidades();
            }
        }

        public override void Editar()
        {

            Teste teste = ObterTesteSelecionado();

            if (teste == null)
            {
                MessageBox.Show($"Selecione uma Teste primeiro!",
                    "Edição de Testes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaTesteForm telaTeste = new TelaTesteForm(repositorioMateria, repositorioDisciplina, repositorioQuestao);
            telaTeste.Teste = teste;
            telaTeste.ListaQuestoes = teste.listaQuestoes;

            DialogResult opcaoEscolhida = telaTeste.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioTeste.Atualizar(telaTeste.Teste.id, telaTeste.Teste);

                CarregarEntidades();
            }
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

        public override void DuplicarTesteSelecionado()
        {
            
            Teste teste = ObterTesteSelecionado();
            teste.id = 0;
            teste.materia.id = 0;
            teste.disciplina.id = 0;
           
             repositorioTeste.Inserir(teste);
                CarregarEntidades();

        }
        public override void GerarPDF()
        {
            Teste teste = ObterTesteSelecionado();
            string pathArquivo = GeradorDePDFdeTeste.pathArquivo("TESTE");
            if (teste == null)
            {
                MessageBox.Show($"Selecione uma Teste primeiro!",
                    "PDF do Teste",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }
            GeradorDePDFdeTeste.PdfTeste(pathArquivo, teste.id);
             MessageBox.Show($"PDF Gerado com Sucesso!",
                  "PDF Concluído",
                  MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }

        public override void VisualizarItems()
        {      
            Teste teste = ObterTesteSelecionado();
            TelaVisualizarQuestoesForm telaVisualizarQuestoes = new(repositorioTeste,teste);
            telaVisualizarQuestoes.ShowDialog();
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
        private Teste ObterTesteSelecionado()
        {
            int id = tabelaTestes.ObterIdSelecionado();

            return repositorioTeste.Busca(id);
        }
    }
}
