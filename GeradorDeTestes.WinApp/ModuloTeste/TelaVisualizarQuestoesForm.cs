
using GeradorDeTestes.Dominio.ModuloQuestao;
using GeradorDeTestes.Dominio.ModuloTeste;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeTestes.WinApp.ModuloTeste
{
    public partial class TelaVisualizarQuestoesForm : Form
    {
        public TelaVisualizarQuestoesForm(IRepositorioTeste repositorioTeste, Teste teste)
        {
            InitializeComponent();
            this.ConfigurarDialog();
            ConfigurarTela(repositorioTeste,teste);
        }

        private void ConfigurarTela(IRepositorioTeste repositorioTeste, Teste teste)
        {
            lblTituloProva.Text = teste.titulo;
            foreach(Questao questao in repositorioTeste.RetornarTodasAsRespostas(teste.id))
            {
                listQuestoes.Items.Add(questao);
            }
        }
    }
}
