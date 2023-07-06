
namespace GeradorDeTestes.WinApp.ModuloDisciplina
{
    public partial class TelaDisciplinaForm : Form
    {

        private Disciplina disciplina;
        public TelaDisciplinaForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }

        public Disciplina Disciplina
        {
            set
            {
                ConfigurarValores(value);
            }
            get
            {
                return disciplina;
            }
        }

        private void ConfigurarValores(Disciplina value)
        {
            txtId.Text = value.id.ToString();
            txtNome.Text = value.nome;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            disciplina = ObterDisciplina();

            string[] erros = disciplina.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipal.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
            }

            if (txtId.Text != "0")
                disciplina.id = Convert.ToInt32(txtId.Text);
        }

        private Disciplina ObterCliente()
        {
            string nome = txtNome.Text;
            return disciplina = new Disciplina(nome);
        }
    }

}