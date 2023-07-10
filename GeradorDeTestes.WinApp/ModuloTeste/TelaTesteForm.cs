using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.Dominio.ModuloQuestao;
using GeradorDeTestes.Dominio.ModuloTeste;
using GeradorDeTestes.Infra.Dados.Sql.ModuloQuestao;
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
    public partial class TelaTesteForm : Form
    {
        public Materia materiaSelecionada;
        public IRepositorioQuestao repositorioQuestao;
        public TelaTesteForm(IRepositorioMateria repositorioMateria, IRepositorioDisciplina repositorioDisciplina, IRepositorioQuestao repositorioQuestao)
        {
            InitializeComponent();
            this.repositorioQuestao = repositorioQuestao;
            AdicionaAComboBox(repositorioMateria, repositorioDisciplina);
            this.ConfigurarDialog();
        }

        private Teste teste;
        private List<Questao> listaQuestoes;
        public Teste Teste
        {
            set
            {
                ConfigurarValores(value);
            }
            get
            {
                return teste;
            }
        }
        public List<Questao> ListaQuestoes
        {
            set
            {
                ConfigurarLista(value);
            }
            get
            {
                return listaQuestoes;
            }
        }

        private void ConfigurarLista(List<Questao> value)
        {
            foreach (Questao item in value)
            {
                listQuestoesAleatorias.Items.Add(item);
            }
            
        }

        private void ConfigurarValores(Teste value)
        {
            if (value.materia != null)
            {
                cmbBoxMateria.SelectedItem = value.materia;
            }
            if (value.disciplina != null)
            {
                cmbBoxDisciplina.SelectedItem = value.disciplina;
            }
            txtId.Text = value.id.ToString();
            txtTitulo.Text = value.titulo;
            nmrQtdQuestoes.Value = value.quantQuestoes;

        }
        private void AdicionaAComboBox(IRepositorioMateria repositorioMateria, IRepositorioDisciplina repositorioDisciplina)
        {
            foreach (Materia materia in repositorioMateria.RetornarTodos())
            {
                cmbBoxMateria.Items.Add(materia);
            }
            foreach (Disciplina disciplina in repositorioDisciplina.RetornarTodos())
            {
                cmbBoxDisciplina.Items.Add(disciplina);
            }
        }

        private Teste ObterTeste()
        {

            string titulo = txtTitulo.Text;
            DateTime dataDeGeracao = DateTime.UtcNow.Date;
            materiaSelecionada = (Materia)cmbBoxMateria.SelectedItem;
            Disciplina disciplina = (Disciplina)cmbBoxDisciplina.SelectedItem;
            int quatidadeQuestoes = Convert.ToInt32(nmrQtdQuestoes.Value);
            List<Questao> questoes = new();

            foreach (Questao questao in listQuestoesAleatorias.Items)
            {
                questoes.Add(questao);
            }


            return teste = new Teste(titulo, dataDeGeracao, disciplina, materiaSelecionada, quatidadeQuestoes, questoes);
        }

        private void btnSortearQuestoes_Click(object sender, EventArgs e)
        {
            ConfigurarListaAleatoria(repositorioQuestao);
        }
        private void ConfigurarListaAleatoria(IRepositorioQuestao repositorioQuestao)
        {
            listQuestoesAleatorias.Items.Clear();
            materiaSelecionada = (Materia)cmbBoxMateria.SelectedItem;

            for (int i = 0; i < nmrQtdQuestoes.Value; i++)
            {
                Questao questao = null;
                Random Aleatorio = new Random();
                int numeroAleatorio = Aleatorio.Next(0, Convert.ToInt32(nmrQtdQuestoes.Value));
                if (nmrQtdQuestoes.Value >= repositorioQuestao.RetornarTodasAsQuestoesDaMateria(materiaSelecionada).Count)
                    return;
                else
                    questao = repositorioQuestao.RetornarTodasAsQuestoesDaMateria(materiaSelecionada).ToArray()[Convert.ToInt32(numeroAleatorio)];

                listQuestoesAleatorias.Items.Add(questao);


            }

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            teste = ObterTeste();
            listaQuestoes = new();
            foreach (Questao questao in listQuestoesAleatorias.Items)
            {
                listaQuestoes.Add(questao);
            }
            string[] erros = teste.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipal.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
            }
                              
            if (txtId.Text != "0")
                teste.id = Convert.ToInt32(txtId.Text);
        }
    }
}
