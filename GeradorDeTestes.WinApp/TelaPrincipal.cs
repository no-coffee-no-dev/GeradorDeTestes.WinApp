using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.Dominio.ModuloQuestao;
using GeradorDeTestes.Infra.Dados.Sql.ModuloQuestao;
using GeradorDeTestes.WinApp.ModuloQuestao;
using System.Windows.Forms;

namespace GeradorDeTestes.WinApp
{
    public partial class TelaPrincipal : Form
    {
        UserControl listagem;
        private ControladorBase controlador;
        private Dictionary<string, ControladorBase> controladores;

        //IRepositorioDisciplina repositorioDisciplina = new RepositorioDisciplinaEmSql();
        //IRepositorioMateria repositorioMateria = new RepositorioMateriaEmSql();
        IRepositorioQuestao repositorioQuestao = new RepositorioQuestaoEmSql();
        IRepositorioMateria repositorioMateria = null;
        //IRepositorioTeste repositorioTeste = new RepositorioTesteEmSql();

        private static TelaPrincipal telaPrincipal;

        public TelaPrincipal()
        {
            InitializeComponent();
            Instancia = this;
            labelRodape.Text = string.Empty;
            lblTipoDeCadastro.Text = string.Empty;

            //InicializarControladores();
        }
        public static TelaPrincipal Instancia
        {
            get;
            private set;
        }
        public void AtualizarRodape(string mensagem)
        {
            labelRodape.Text = mensagem;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Deletar();
        }

        private void disciplinasMenuItem_Click(object sender, EventArgs e)
        {
           // ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
        }

        private void materiaMenuItem_Click(object sender, EventArgs e)
        {
            //List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();

            //if (disciplinas.Count > 0)
            //{
            //    ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
            //}
            //else
            //{
            //    AtualizarRodape("Crie uma Disciplina Primeiro");
            //}

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

        private void disciplinasMenuItem_Click(object sender, EventArgs e)
        {
            // ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
        }

        private void materiaMenuItem_Click(object sender, EventArgs e)
        {
            //List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();

            //if (disciplinas.Count > 0)
            //{
            //    ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
            //}
            //else
            //{
            //    AtualizarRodape("Crie uma Disciplina Primeiro");
            //}

        }

        private void questaoMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorQuestao(repositorioQuestao,repositorioMateria);
            ConfigurarTelaPrincipal(controlador);
        }
        private void testeMenuItem_Click(object sender, EventArgs e)
        {
            //ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
        }
        private void ConfigurarBotoes(ControladorBase controlador)
        {
            btnInserir.Enabled = controlador.BotaoInserirAtivado;
            btnEditar.Enabled = controlador.BotaoEditarAtivado;
            btnExcluir.Enabled = controlador.BotaoDeletarAtivado;

        }

        private void ConfigurarTooltips(ControladorBase controlador)
        {
            btnInserir.ToolTipText = controlador.ToolTipInserir;
            btnEditar.ToolTipText = controlador.ToolTipEditar;
            btnExcluir.ToolTipText = controlador.ToolTipExcluir;

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
                MessageBox.Show("Selecione uma opção de cadastro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }




        //private void InicializarControladores()
        //{
        //    repositorioDisciplina = new RepositorioDisciplinaEmBancoDeDados();
        //    repositorioMateria = new RepositorioMateriaEmBancoDeDados();
        //    repositorioQuestao = new RepositorioQuestaoEmBancoDeDados();
        //    repositorioTeste = new RepositorioTesteEmBancoDeDados();

        //    controladores = new Dictionary<string, ControladorBase>();

        //    controladores.Add("Disciplina", new ControladorDisciplina(repositorioDisciplina, repositorioMateria));
        //    controladores.Add("Matéria", new ControladorMateria(repositorioMateria, repositorioDisciplina));
        //    controladores.Add("Questão", new ControladorQuestao(repositorioDisciplina, repositorioMateria, repositorioQuestao));
        //    controladores.Add("Teste", new ControladorTeste(repositorioTeste, repositorioMateria, repositorioDisciplina, repositorioQuestao));
        //}

    }
}