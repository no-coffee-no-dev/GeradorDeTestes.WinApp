using System.Windows.Forms;

namespace GeradorDeTestes.WinApp
{
    public partial class TelaPrincipal : Form
    {
        private ControladorBase controlador;
        private Dictionary<string, ControladorBase> controladores;
        private DataContext contextoDados;


        public TelaPrincipal(DataContext contextoDados)
        {
            InitializeComponent();
            Instancia = this;

            labelRodape.Text = string.Empty;
            labelTipoCadastro.Text = string.Empty;

            this.contextoDados = contextoDados;

            InicializarControladores();
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
            controlador.Excluir();
        }

        private void disciplinasMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
        }

        private void materiaMenuItem_Click(object sender, EventArgs e)
        {
            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();

            if (disciplinas.Count > 0)
            {
                ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
            }
            else
            {
                AtualizarRodape("Crie uma Disciplina Primeiro");
            }

        }

        private void questaoMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
        }

        private void testeMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender); ;
        }
        private void ConfigurarBotoes(ConfiguracaoToolBoxBase configuracao)
        {
            btnInserir.Enabled = configuracao.InserirHabilitado;
            btnEditar.Enabled = configuracao.EditarHabilitado;
            btnExcluir.Enabled = configuracao.ExcluirHabilitado;

        }

        private void ConfigurarTooltips(ConfiguracaoToolBoxBase configuracao)
        {
            btnInserir.ToolTipText = configuracao.TooltipInserir;
            btnEditar.ToolTipText = configuracao.TooltipEditar;
            btnExcluir.ToolTipText = configuracao.TooltipExcluir;

        }

        private void ConfigurarTelaPrincipal(ToolStripMenuItem opcaoSelecionada)
        {
            var tipo = opcaoSelecionada.Text;

            controlador = controladores[tipo];

            ConfigurarToolbox();

            ConfigurarListagem();
        }

        private void ConfigurarToolbox()
        {
            ConfiguracaoToolBoxBase configuracao = controlador.ObtemConfiguracaoToolbox();

            if (configuracao != null)
            {
                toolStrip1.Enabled = true;

                labelTipoCadastro.Text = configuracao.TipoCadastro;

                ConfigurarTooltips(configuracao);

                ConfigurarBotoes(configuracao);
            }
        }

        private void ConfigurarListagem()
        {
            AtualizarRodape("");

            var listagemControl = controlador.ObtemListagem();

            panelRegistros.Controls.Clear();

            listagemControl.Dock = DockStyle.Fill;

            panelRegistros.Controls.Add(listagemControl);
        }

        private void InicializarControladores()
        {
            repositorioDisciplina = new RepositorioDisciplinaEmBancoDeDados();
            repositorioMateria = new RepositorioMateriaEmBancoDeDados();
            repositorioQuestao = new RepositorioQuestaoEmBancoDeDados();
            repositorioTeste = new RepositorioTesteEmBancoDeDados();

            controladores = new Dictionary<string, ControladorBase>();

            controladores.Add("Disciplina", new ControladorDisciplina(repositorioDisciplina, repositorioMateria));
            controladores.Add("Matéria", new ControladorMateria(repositorioMateria, repositorioDisciplina));
            controladores.Add("Questão", new ControladorQuestao(repositorioDisciplina, repositorioMateria, repositorioQuestao));
            controladores.Add("Teste", new ControladorTeste(repositorioTeste, repositorioMateria, repositorioDisciplina, repositorioQuestao));
        }

    }
}