using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.Dominio.ModuloQuestao;
using GeradorDeTestes.Dominio.ModuloTeste;
using GeradorDeTestes.Infra.Dados.Sql.ModuloDisciplina;
using GeradorDeTestes.Infra.Dados.Sql.ModuloMateria;
using GeradorDeTestes.Infra.Dados.Sql.ModuloQuestao;
using GeradorDeTestes.Infra.Dados.Sql.ModuloTeste;
using GeradorDeTestes.Infra.Dados.Sql.ModuloDisciplina;
using GeradorDeTestes.WinApp.ModuloDisciplina;
using GeradorDeTestes.WinApp.ModuloMateria;
using GeradorDeTestes.WinApp.ModuloQuestao;
using GeradorDeTestes.WinApp.ModuloTeste;
using System.Windows.Forms;
using GeradorDeTestes.Dominio.ModuloDisciplina;

namespace GeradorDeTestes.WinApp
{
    public partial class TelaPrincipal : Form
    {
        UserControl listagem;
        private ControladorBase controlador;
        private Dictionary<string, ControladorBase> controladores;

        IRepositorioDisciplina repositorioDisciplina = new RepositorioDisciplinaEmSql();
        IRepositorioQuestao repositorioQuestao = new RepositorioQuestaoEmSql();
        IRepositorioMateria repositorioMateria = new RepositorioMateriaEmSql();
        IRepositorioTeste repositorioTeste = new RepositorioTesteEmSql();

        private static TelaPrincipal telaPrincipal;

        public TelaPrincipal()
        {
            InitializeComponent();
            telaPrincipal = this;
        }

        public static TelaPrincipal Instancia
        {
            get
            {
                if (telaPrincipal == null)
                    telaPrincipal = new TelaPrincipal();

                return telaPrincipal;
            }
        }
        public void AtualizarRodape(string mensagem)
        {
            labelRodape.Text = mensagem;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (VerificaControladorVazio(controlador)) ;
            else
                controlador.Inserir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (VerificaControladorVazio(controlador)) ;
            else
                controlador.Editar();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (VerificaControladorVazio(controlador)) ;
            else
                controlador.Deletar();
        }

        private void btnVisualizarItems_Click(object sender, EventArgs e)
        {
            if (VerificaControladorVazio(controlador)) ;
            else
                controlador.VisualizarItems();
        }

        private void brnGerarPDF_Click(object sender, EventArgs e)
        {
            if (VerificaControladorVazio(controlador)) ;
            else
                controlador.GerarPDF();

        }
        private void disciplinasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorDisciplina(repositorioDisciplina);
            ConfigurarTelaPrincipal(controlador);
        }

        private void materiaMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorMateria(repositorioMateria, repositorioDisciplina);
            ConfigurarTelaPrincipal(controlador);

        }

        private void questaoMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorQuestao(repositorioQuestao, repositorioMateria, repositorioDisciplina);
            ConfigurarTelaPrincipal(controlador);
        }
        private void testeMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTeste(repositorioQuestao, repositorioMateria, repositorioDisciplina, repositorioTeste);
            ConfigurarTelaPrincipal(controlador);
        }


        private void tsbDuplicar_Click(object sender, EventArgs e)
        {
            if (VerificaControladorVazio(controlador)) ;
            else
                controlador.DuplicarTesteSelecionado();

        }




        private void ConfigurarBotoes(ControladorBase controlador)
        {
            btnInserir.Enabled = controlador.BotaoInserirAtivado;
            btnEditar.Enabled = controlador.BotaoEditarAtivado;
            btnExcluir.Enabled = controlador.BotaoDeletarAtivado;
            btnVisualizarItems.Enabled = controlador.BotaoVisualizarItensAtivado;
            btnGerarPDF.Enabled = controlador.BotaoGerarPDFAtivado;
            btnDuplicar.Enabled = controlador.BotaoDuplicarTesteAtivado;


        }

        private void ConfigurarTooltips(ControladorBase controlador)
        {
            btnInserir.ToolTipText = controlador.ToolTipInserir;
            btnEditar.ToolTipText = controlador.ToolTipEditar;
            btnExcluir.ToolTipText = controlador.ToolTipExcluir;
            btnVisualizarItems.ToolTipText = controlador.ToolTipVisualizarItens;

        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorBase)
        {
            lblTipoDeCadastro.Text = controladorBase.ObterTipoCadastro();

            ConfigurarTooltips(controladorBase);
            ConfigurarListagem(controladorBase);
            ConfigurarBotoes(controladorBase);

        }

        private void ConfigurarListagem(ControladorBase controlador)
        {
            AtualizarRodape("");

            listagem = controlador.ObterListagem();

            panelRegistros.Controls.Clear();

            listagem.Dock = DockStyle.Fill;

            panelRegistros.Controls.Add(listagem);
        }

        private bool VerificaControladorVazio(ControladorBase controlador)
        {
            if (controlador == null)
            {
                MessageBox.Show("Selecione uma op��o de cadastro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }




    }
}