using FluentResults;
using GeradorDeTestes.Aplicacao.ModuloDisciplina;
using GeradorDeTestes.Aplicacao.ModuloQuestao;
using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloQuestao;
using GeradorDeTestes.WinApp.ModuloQuestao;

namespace GeradorDeTestes.WinApp.ModuloDisciplina
{
    public class ControladorDisciplina : ControladorBase
    {
        private IRepositorioDisciplina repositorioDisciplina;
        private TabelaDisciplinaControl tabelaDisciplina;

        private ServicoDisciplina servicoDisciplina;

        public ControladorDisciplina(IRepositorioDisciplina repositorioDisciplina, ServicoDisciplina servicoDisciplina)
        {
            this.repositorioDisciplina = repositorioDisciplina;
            this.servicoDisciplina = servicoDisciplina;
        }

        public override string ToolTipInserir => "Inserir nova disciplina";

        public override string ToolTipEditar => "Editar disciplina existente";

        public override string ToolTipExcluir => "Editar disciplina existente";


        public override bool BotaoInserirAtivado => true;

        public override bool BotaoDeletarAtivado => true;

        public override bool BotaoEditarAtivado => true;

        public override bool BotaoVisualizarItensAtivado => true;


        public override bool BotaoGerarPDFAtivado => false;

        public override bool BotaoDuplicarTesteAtivado => false;

        public override void Deletar()
        {

            Disciplina disciplina = ObterEntidadeSelecionado();

            if (disciplina == null)
            {
                MessageBox.Show($"Selecione uma disciplina primeiro!",
                    "Exclusão de desciplinas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a disciplina {disciplina.nome}?", "Exclusão de Disciplinas",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                Result resultado = servicoDisciplina.Deletar(disciplina);

                if (resultado.IsFailed)
                {
                    MessageBox.Show(resultado.Errors[0].Message, "Exclusão de Disciplinas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                CarregarEntidades();
            }
        }

        public override void Editar()
        {

            Disciplina disciplina = ObterEntidadeSelecionado();

            if (disciplina == null)
            {
                MessageBox.Show($"Selecione uma disciplina primeiro!",
                    "Edição de disciplinas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaDisciplinaForm telaDisciplina = new TelaDisciplinaForm();

            telaDisciplina.Disciplina = disciplina;

            telaDisciplina.onInserirEntidade += servicoDisciplina.Atualizar;

            DialogResult opcaoEscolhida = telaDisciplina.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                CarregarEntidades();
            }
        }

        public override void Inserir()
        {
            TelaDisciplinaForm telaDisciplina = new TelaDisciplinaForm();

            telaDisciplina.onInserirEntidade += servicoDisciplina.Inserir;

            DialogResult opcaoEscolhida = telaDisciplina.ShowDialog();

            Disciplina disciplina = telaDisciplina.Disciplina;

            if (opcaoEscolhida == DialogResult.OK)
            {               
                CarregarEntidades();
            }
        }

        public override void VisualizarItems()
        {

            Disciplina disciplina = ObterDisciplinaSelecionada();
            TelaVisualizarItemsForm telaVisualizarItems = new TelaVisualizarItemsForm(repositorioDisciplina, disciplina);
            telaVisualizarItems.ShowDialog();
        }


        public override UserControl ObterListagem()
        {
            if (tabelaDisciplina == null)
                tabelaDisciplina = new TabelaDisciplinaControl();

            CarregarEntidades();

            return tabelaDisciplina;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de disciplinas";
        }

        public Disciplina ObterEntidadeSelecionado()
        {
            int id = tabelaDisciplina.ObterIdSelecionado();

            return repositorioDisciplina.Busca(id);
        }

        public override void CarregarEntidades()
        {
            List<Disciplina> disciplina = repositorioDisciplina.RetornarTodos();
            tabelaDisciplina.AtualizarRegistros(disciplina);
        }

        private Disciplina ObterDisciplinaSelecionada()
        {
            int id = tabelaDisciplina.ObterIdSelecionado();

            return repositorioDisciplina.Busca(id);
        }
    }
}