﻿using GeradorDeTestes.Dominio.ModuloDisciplina;
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
using static GeradorDeTestes.Dominio.ModuloMateria.Materia;

namespace GeradorDeTestes.WinApp.ModuloMateria
{
    public partial class TelaMateriaForm : Form
    {
        private Materia materia;
        public TelaMateriaForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
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

        private void ConfigurarValores(Materia value)
        {
            txtNome.Text = value.nome;
        }
        private Materia ObterMateria()
        {
            string nome = txtNome.Text;
            Disciplina disiplina = (Disciplina)cbxDisiplina.SelectedItem;
            string SerieSelecionada = "";
            if (rbSerie1.Checked)
            {
                SerieSelecionada = "1°";
            }
            if (rbSerie2.Checked)
            {
                SerieSelecionada = "2°";
            }
            
            


            return materia = new Materia(nome, disiplina, SerieSelecionada);
        }
    }
}
