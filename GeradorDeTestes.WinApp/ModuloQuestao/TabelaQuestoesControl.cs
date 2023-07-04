using GeradorDeTestes.Dominio.ModuloQuestao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeTestes.WinApp.ModuloQuestao
{
    public partial class TabelaQuestoesControl : UserControl
    {
        public TabelaQuestoesControl()
        {
            InitializeComponent();
            ConfigurarColunas();
            ConfigurarGrid();
        }

        private void ConfigurarGrid()
        {
            tabelaQuestoes.ConfigurarGridZebrado();

            tabelaQuestoes.ConfigurarGridSomenteLeitura();

            tabelaQuestoes.ConfigurarGridDockFill();

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
                    Name = "titulo",
                    HeaderText = "Título"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "materia",
                    HeaderText = "Matéria"
                }
            };

            tabelaQuestoes.Columns.AddRange(colunas);
        }

        public void AtualizarRegistros(List<Questao> questoes)
        {
            tabelaQuestoes.Rows.Clear();
            foreach (Questao questao in questoes)
            {
                tabelaQuestoes.Rows.Add(questao.id, questao.titulo,questao.materia.nome);
            }
        }
        public int ObterIdSelecionado()
        {
            int id;

            try
            {
                id = Convert.ToInt32(tabelaQuestoes.SelectedRows[0].Cells["id"].Value);
            }
            catch
            {
                id = -1;
            }

            return id;
        }
    }
}
