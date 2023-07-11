namespace GeradorDeTestes.WinApp.ModuloTeste
{
    partial class TelaTesteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTitulo = new TextBox();
            txtId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cmbBoxDisciplina = new ComboBox();
            label3 = new Label();
            cmbBoxMateria = new ComboBox();
            nmrQtdQuestoes = new NumericUpDown();
            label4 = new Label();
            btnSortearQuestoes = new Button();
            listQuestoesAleatorias = new ListBox();
            groupBox1 = new GroupBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)nmrQtdQuestoes).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(79, 31);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(273, 23);
            txtTitulo.TabIndex = 20;
            // 
            // txtId
            // 
            txtId.Location = new Point(-2, 552);
            txtId.Multiline = true;
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(10, 11);
            txtId.TabIndex = 39;
            txtId.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 39);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 40;
            label2.Text = "Título:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 90);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 41;
            label1.Text = "Disciplina:";
            // 
            // cmbBoxDisciplina
            // 
            cmbBoxDisciplina.FormattingEnabled = true;
            cmbBoxDisciplina.Location = new Point(79, 87);
            cmbBoxDisciplina.Name = "cmbBoxDisciplina";
            cmbBoxDisciplina.Size = new Size(78, 23);
            cmbBoxDisciplina.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 90);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 43;
            label3.Text = "Matéria:";
            // 
            // cmbBoxMateria
            // 
            cmbBoxMateria.FormattingEnabled = true;
            cmbBoxMateria.Location = new Point(274, 87);
            cmbBoxMateria.Name = "cmbBoxMateria";
            cmbBoxMateria.Size = new Size(78, 23);
            cmbBoxMateria.TabIndex = 44;
            // 
            // nmrQtdQuestoes
            // 
            nmrQtdQuestoes.Location = new Point(320, 149);
            nmrQtdQuestoes.Name = "nmrQtdQuestoes";
            nmrQtdQuestoes.Size = new Size(32, 23);
            nmrQtdQuestoes.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(218, 155);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 46;
            label4.Text = "Qtd. Questões:";
            // 
            // btnSortearQuestoes
            // 
            btnSortearQuestoes.Location = new Point(12, 149);
            btnSortearQuestoes.Name = "btnSortearQuestoes";
            btnSortearQuestoes.Size = new Size(145, 27);
            btnSortearQuestoes.TabIndex = 47;
            btnSortearQuestoes.Text = "Sortear Questões";
            btnSortearQuestoes.UseVisualStyleBackColor = true;
            btnSortearQuestoes.Click += btnSortearQuestoes_Click;
            // 
            // listQuestoesAleatorias
            // 
            listQuestoesAleatorias.FormattingEnabled = true;
            listQuestoesAleatorias.ItemHeight = 15;
            listQuestoesAleatorias.Location = new Point(0, 22);
            listQuestoesAleatorias.Name = "listQuestoesAleatorias";
            listQuestoesAleatorias.Size = new Size(349, 259);
            listQuestoesAleatorias.TabIndex = 48;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listQuestoesAleatorias);
            groupBox1.Location = new Point(12, 206);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(349, 289);
            groupBox1.TabIndex = 49;
            groupBox1.TabStop = false;
            groupBox1.Text = "Questões Selecionadas";
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(205, 505);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 41);
            btnGravar.TabIndex = 50;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(286, 505);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 51;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaTesteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 558);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(groupBox1);
            Controls.Add(btnSortearQuestoes);
            Controls.Add(label4);
            Controls.Add(nmrQtdQuestoes);
            Controls.Add(cmbBoxMateria);
            Controls.Add(label3);
            Controls.Add(cmbBoxDisciplina);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(txtTitulo);
            Name = "TelaTesteForm";
            Text = "Cadastro de Teste";
            ((System.ComponentModel.ISupportInitialize)nmrQtdQuestoes).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitulo;
        private TextBox txtId;
        private Label label2;
        private Label label1;
        private ComboBox cmbBoxDisciplina;
        private Label label3;
        private ComboBox cmbBoxMateria;
        private NumericUpDown nmrQtdQuestoes;
        private Label label4;
        private Button btnSortearQuestoes;
        private ListBox listQuestoesAleatorias;
        private GroupBox groupBox1;
        private Button btnGravar;
        private Button btnCancelar;
    }
}