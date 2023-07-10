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
using System.Windows.Forms.VisualStyles;

namespace GeradorDeTestes.WinApp.ModuloQuestao
{
    public partial class TelaVisualizarItemsForm : Form
    {
        public TelaVisualizarItemsForm(IRepositorioQuestao repositorioQuestao, Questao questao)
        {
            InitializeComponent();
            this.ConfigurarDialog();
            ConfigurarTela(repositorioQuestao,questao);
        }

        private void ConfigurarTela(IRepositorioQuestao repositorioQuestao, Questao questao)
        {
            lblTituloPergunta.Text = questao.titulo;
            foreach (string resposta in repositorioQuestao.RetornarTodasAsOpcoes(questao))
            {
                listRespostas.Items.Add(resposta);
            }
        }
    }
}
