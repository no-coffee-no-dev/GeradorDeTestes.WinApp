
using GeradorDeTestes.Dominio.ModuloDisciplina;

namespace GeradorDeTestes.WinApp.ModuloDisciplina
{
    public partial class TabelaDisciplinaControl : UserControl
    {
        public TabelaDisciplinaControl()
        {
            InitializeComponent();
            ConfigurarColunas();
            ConfigurarGrid();
        }
        private void ConfigurarGrid()
        {
            tabelaDisciplina.ConfigurarGridZebrado();

            tabelaDisciplina.ConfigurarGridSomenteLeitura();

            tabelaDisciplina.ConfigurarGridDockFill();

        }
        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    Name = "id",
                    HeaderText = "Id"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "nome",
                    HeaderText = "Nome"
                }
            };

            tabelaDisciplina.Columns.AddRange(colunas);
        }
        public void AtualizarRegistros(List<Disciplina> disciplinas)
        {
            tabelaDisciplina.Rows.Clear();
            foreach (Disciplina disciplina in disciplinas)
            {
                tabelaDisciplina.Rows.Add(disciplina.id, disciplina.nome);
            }
        }

        public int ObterIdSelecionado()
        {
            int id;

            try
            {
                id = Convert.ToInt32(tabelaDisciplina.SelectedRows[0].Cells["id"].Value);
            }
            catch
            {
                id = -1;
            }

            return id;
        }
    }
}