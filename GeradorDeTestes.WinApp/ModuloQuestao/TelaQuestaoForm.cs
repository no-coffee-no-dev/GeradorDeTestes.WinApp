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
        public TelaQuestaoForm()
        {
            InitializeComponent();
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

            txtTitulo.Text = value.titulo;
            txtRespostaA.Text = value.opcoaoA;
            txtRespostaB.Text = value.opcoaoB;
            txtRespostaC.Text = value.opcoaoC;
            txtRespostaD.Text = value.opcoaoD;
        }


        private void btnGravar_Click(object sender, EventArgs e)
        {
            questao = ObterQuestao();

            string[] erros = questao.Validar();

            if (erros.Length > 0)
            {
                //TelaPrincipal.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
            }

        }
       
        private void AdicionaAComboBox(IRepositorioCliente repositorioCliente)
        {
            foreach (Cliente cliente in repositorioCliente.RetornarTodos())
            {
                CBX_CLIENTE.Items.Add(cliente);
            }

            foreach (Tema tema in repositorioTema.RetornarTodos())
            {
                CBX_TEMA.Items.Add(tema);
            }
        }


        private Questao ObterQuestao()
        {
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


            return questao = new Questao(titulo, opcaoA, opcaoB, opcaoC, opcaoD, respostaCorreta, materia);
        }
    }
}
