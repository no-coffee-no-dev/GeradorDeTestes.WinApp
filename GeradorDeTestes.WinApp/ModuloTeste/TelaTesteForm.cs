using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;
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
    public partial class TelaTesteForm : Form
    {
        public TelaTesteForm(IRepositorioMateria repositorioMateria, IRepositorioDisciplina repositorioDisciplina)
        {
            InitializeComponent();
            AdicionaAComboBox(repositorioMateria, repositorioDisciplina);
            this.ConfigurarDialog();
        }

        private Teste teste;
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




            Materia materia = (Materia)cmbBoxMateria.SelectedItem;


            return questao = new Questao(titulo, opcaoA, opcaoB, opcaoC, opcaoD, respostaCorreta, materia);
        }

        private void btnSortearQuestoes_Click(object sender, EventArgs e)
        {
        }
        private void ConfigurarListaAleatoria()
        {
            foreach (Materia materia in repositorioMateria.RetornarTodos())
            {
                cmbBoxMateria.Items.Add(materia);
            }
        }

    }
}
