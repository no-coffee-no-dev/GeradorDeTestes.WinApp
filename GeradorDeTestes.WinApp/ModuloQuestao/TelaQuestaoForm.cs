using FluentResults;
using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;
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
    public partial class TelaQuestaoForm : Form
    {
        private Questao questao;

        public event InserirEntidadeDelegate<Questao> onInserirEntidade;
        public TelaQuestaoForm(IRepositorioMateria repositorioMateria, IRepositorioDisciplina repositorioDisciplina)
        {
            InitializeComponent();
            AdicionaAComboBox(repositorioMateria,repositorioDisciplina);
            this.ConfigurarDialog();
        }

        public Questao Questao
        {
            set
            {
                ConfigurarValores(value);
            }
            get
            {
                return questao;
            }
        }

        private void ConfigurarValores(Questao value)
        {
            if (value.materia != null)
            {
                cmbBoxMateria.SelectedItem = value.materia;
            }
            txtId.Text = value.id.ToString();
            txtTitulo.Text = value.titulo;
            txtRespostaA.Text = value.opcoaoA;
            txtRespostaB.Text = value.opcoaoB;
            txtRespostaC.Text = value.opcoaoC;
            txtRespostaD.Text = value.opcoaoD;
            if(value.opcoaoA == value.respostaCorreta)
            {
                rdBtnOpcaoA.Checked = true;
            }
            if (value.opcoaoB == value.respostaCorreta)
            {
                rdBtnOpcaoB.Checked = true;
            }
            if (value.opcoaoC == value.respostaCorreta)
            {
                rdBtnOpcaoC.Checked = true;
            }
            if (value.opcoaoC == value.respostaCorreta)
            {
                rdBtnOpcaoC.Checked = true;
            }
            if (value.opcoaoD == value.respostaCorreta)
            {
                rdBtnOpcaoD.Checked = true;
            }
        }


        private void btnGravar_Click(object sender, EventArgs e)
        {
            questao = ObterQuestao();

            Result resultado = onInserirEntidade(questao);

            if (resultado.IsFailed)
            {
                TelaPrincipal.Instancia.AtualizarRodape(resultado.Errors[0].Message);
                DialogResult = DialogResult.None;
            }

            if (txtId.Text != "0")
                questao.id = Convert.ToInt32(txtId.Text);
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


        private Questao ObterQuestao()
        {
            int id = Convert.ToInt32(txtId.Text);
            string titulo = txtTitulo.Text;
            string opcaoA = txtRespostaA.Text;
            string opcaoB = txtRespostaB.Text;
            string opcaoC = txtRespostaC.Text;
            string opcaoD = txtRespostaD.Text;
            string respostaCorreta = "";
            if (rdBtnOpcaoA.Checked)
            {
                respostaCorreta = txtRespostaA.Text;
            }
            if (rdBtnOpcaoB.Checked)
            {
                respostaCorreta = txtRespostaB.Text;
            }
            if (rdBtnOpcaoC.Checked)
            {
                respostaCorreta = txtRespostaC.Text;
            }
            if (rdBtnOpcaoD.Checked)
            {
                respostaCorreta = txtRespostaD.Text;
            }
            Materia materia = (Materia)cmbBoxMateria.SelectedItem;


            
            questao = new Questao(titulo, opcaoA, opcaoB, opcaoC, opcaoD, respostaCorreta, materia);
            questao.id = id;
            return questao;
        }
    }
}
