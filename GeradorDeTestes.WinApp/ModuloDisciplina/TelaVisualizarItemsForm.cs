using GeradorDeTestes.Dominio.ModuloDisciplina;

namespace GeradorDeTestes.WinApp.ModuloDisciplina
{
    public partial class TelaVisualizarItemsForm : Form
    {
        public TelaVisualizarItemsForm(IRepositorioDisciplina repositorioDisciplina, Disciplina disciplina)
        {
            InitializeComponent();
            this.ConfigurarDialog();
            ConfigurarTela(repositorioDisciplina, disciplina);
        }

        private void ConfigurarTela(IRepositorioDisciplina repositorioDisciplina, Disciplina disciplina)
        {
            lblTituloPergunta.Text = disciplina.nome;
            foreach (string tituloQuestao in repositorioDisciplina.RetornarQuestoesRelacionadas(disciplina))
            {
                listRespostas.Items.Add(tituloQuestao);
            }
        }
    }
}
