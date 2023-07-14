using FluentResults;
using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;


namespace GeradorDeTestes.WinApp.ModuloMateria
{
    public partial class TelaMateriaForm : Form
    {
        private Materia materia;
        public event InserirEntidadeDelegate<Materia> onInserirEntidade;
        public TelaMateriaForm(IRepositorioDisciplina repositorioDisciplina)
        {
            InitializeComponent();
            this.ConfigurarDialog();
            AdicionaAComboBox(repositorioDisciplina);
        }

        public Materia Materia
        {
            set
            {
                ConfigurarValores(value);
            }
            get
            {
                return materia;
            }
        }
        private void AdicionaAComboBox(IRepositorioDisciplina repositorioDisciplina)
        {
            foreach (Disciplina disciplina in repositorioDisciplina.RetornarTodos())
            {
                cbxDisciplina.Items.Add(disciplina);
            }
        }

        private void ConfigurarValores(Materia value)
        {
            txtId.Text = value.id.ToString();
            txtNome.Text = value.nome;
        }
        private Materia ObterMateria()
        {
            int id = Convert.ToInt32(txtId.Text);
            string nome = txtNome.Text;
            Disciplina disiplina = (Disciplina)cbxDisciplina.SelectedItem;
            string SerieSelecionada = "";
            if (rbSerie1.Checked)
            {
                SerieSelecionada = "1°";
            }
            if (rbSerie2.Checked)
            {
                SerieSelecionada = "2°";
            }


          
             materia = new Materia(nome, disiplina, SerieSelecionada);
             materia.id = id;
             return materia;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            materia = ObterMateria();

            Result resultado = onInserirEntidade(materia);

            if (resultado.IsFailed)
            {
                TelaPrincipal.Instancia.AtualizarRodape(resultado.Errors[0].Message);
                DialogResult = DialogResult.None;
            }

            if (txtId.Text != "0")
                materia.id = Convert.ToInt32(txtId.Text);
        }
    }
}
