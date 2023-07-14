
using FluentResults;
using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloTeste;

namespace GeradorDeTestes.WinApp.ModuloDisciplina
{
    public partial class TelaDisciplinaForm : Form
    {

        private Disciplina disciplina;
        public event InserirEntidadeDelegate<Disciplina> onInserirEntidade;
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

            Result resultado = onInserirEntidade(disciplina);

            if (resultado.IsFailed)
            {
                TelaPrincipal.Instancia.AtualizarRodape(resultado.Errors[0].Message);
                DialogResult = DialogResult.None;
            }

            if (txtId.Text != "0")
                disciplina.id = Convert.ToInt32(txtId.Text);
        }

        private Disciplina ObterDisciplina()
        {
            int id = Convert.ToInt32(txtId.Text);
            string nome = txtNome.Text;
            disciplina = new Disciplina(nome);
            disciplina.id = id;
            return disciplina; 
        }
    }

}