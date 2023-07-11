namespace GeradorDeTestes.WinApp.ModuloQuestao
{
    partial class TelaQuestaoForm
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
            label2 = new Label();
            txtTitulo = new TextBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            cmbBoxDisciplina = new ComboBox();
            cmbBoxMateria = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            rdBtnOpcaoA = new RadioButton();
            rdBtnOpcaoB = new RadioButton();
            rdBtnOpcaoC = new RadioButton();
            rdBtnOpcaoD = new RadioButton();
            txtRespostaA = new TextBox();
            txtRespostaB = new TextBox();
            txtRespostaC = new TextBox();
            txtRespostaD = new TextBox();
            txtId = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(144, 112);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 7;
            label2.Text = "Pergunta:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(43, 130);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(273, 23);
            txtTitulo.TabIndex = 19;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(117, 363);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 41);
            btnGravar.TabIndex = 24;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(198, 363);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // cmbBoxDisciplina
            // 
            cmbBoxDisciplina.FormattingEnabled = true;
            cmbBoxDisciplina.Location = new Point(79, 57);
            cmbBoxDisciplina.Name = "cmbBoxDisciplina";
            cmbBoxDisciplina.Size = new Size(78, 23);
            cmbBoxDisciplina.TabIndex = 26;
            // 
            // cmbBoxMateria
            // 
            cmbBoxMateria.FormattingEnabled = true;
            cmbBoxMateria.Location = new Point(245, 57);
            cmbBoxMateria.Name = "cmbBoxMateria";
            cmbBoxMateria.Size = new Size(78, 23);
            cmbBoxMateria.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 60);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 28;
            label1.Text = "Disciplina:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(189, 60);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 29;
            label3.Text = "Matéria:";
            // 
            // rdBtnOpcaoA
            // 
            rdBtnOpcaoA.AutoSize = true;
            rdBtnOpcaoA.Location = new Point(33, 215);
            rdBtnOpcaoA.Name = "rdBtnOpcaoA";
            rdBtnOpcaoA.Size = new Size(35, 19);
            rdBtnOpcaoA.TabIndex = 30;
            rdBtnOpcaoA.TabStop = true;
            rdBtnOpcaoA.Text = "a)";
            rdBtnOpcaoA.UseVisualStyleBackColor = true;
            // 
            // rdBtnOpcaoB
            // 
            rdBtnOpcaoB.AutoSize = true;
            rdBtnOpcaoB.Location = new Point(33, 247);
            rdBtnOpcaoB.Name = "rdBtnOpcaoB";
            rdBtnOpcaoB.Size = new Size(36, 19);
            rdBtnOpcaoB.TabIndex = 31;
            rdBtnOpcaoB.TabStop = true;
            rdBtnOpcaoB.Text = "b)";
            rdBtnOpcaoB.UseVisualStyleBackColor = true;
            // 
            // rdBtnOpcaoC
            // 
            rdBtnOpcaoC.AutoSize = true;
            rdBtnOpcaoC.Location = new Point(33, 282);
            rdBtnOpcaoC.Name = "rdBtnOpcaoC";
            rdBtnOpcaoC.Size = new Size(35, 19);
            rdBtnOpcaoC.TabIndex = 32;
            rdBtnOpcaoC.TabStop = true;
            rdBtnOpcaoC.Text = "c)";
            rdBtnOpcaoC.UseVisualStyleBackColor = true;
            // 
            // rdBtnOpcaoD
            // 
            rdBtnOpcaoD.AutoSize = true;
            rdBtnOpcaoD.Location = new Point(33, 316);
            rdBtnOpcaoD.Name = "rdBtnOpcaoD";
            rdBtnOpcaoD.Size = new Size(36, 19);
            rdBtnOpcaoD.TabIndex = 33;
            rdBtnOpcaoD.TabStop = true;
            rdBtnOpcaoD.Text = "d)";
            rdBtnOpcaoD.UseVisualStyleBackColor = true;
            // 
            // txtRespostaA
            // 
            txtRespostaA.Location = new Point(79, 211);
            txtRespostaA.Name = "txtRespostaA";
            txtRespostaA.Size = new Size(221, 23);
            txtRespostaA.TabIndex = 34;
            // 
            // txtRespostaB
            // 
            txtRespostaB.Location = new Point(79, 243);
            txtRespostaB.Name = "txtRespostaB";
            txtRespostaB.Size = new Size(221, 23);
            txtRespostaB.TabIndex = 35;
            // 
            // txtRespostaC
            // 
            txtRespostaC.Location = new Point(79, 278);
            txtRespostaC.Name = "txtRespostaC";
            txtRespostaC.Size = new Size(221, 23);
            txtRespostaC.TabIndex = 36;
            // 
            // txtRespostaD
            // 
            txtRespostaD.Location = new Point(79, 312);
            txtRespostaD.Name = "txtRespostaD";
            txtRespostaD.Size = new Size(221, 23);
            txtRespostaD.TabIndex = 37;
            // 
            // txtId
            // 
            txtId.Location = new Point(0, 407);
            txtId.Multiline = true;
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(10, 10);
            txtId.TabIndex = 38;
            txtId.Text = "0";
            // 
            // TelaQuestaoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 416);
            Controls.Add(txtId);
            Controls.Add(txtRespostaD);
            Controls.Add(txtRespostaC);
            Controls.Add(txtRespostaB);
            Controls.Add(txtRespostaA);
            Controls.Add(rdBtnOpcaoD);
            Controls.Add(rdBtnOpcaoC);
            Controls.Add(rdBtnOpcaoB);
            Controls.Add(rdBtnOpcaoA);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(cmbBoxMateria);
            Controls.Add(cmbBoxDisciplina);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtTitulo);
            Controls.Add(label2);
            Name = "TelaQuestaoForm";
            Text = "Cadastro de Questão";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtTitulo;
        private Button btnGravar;
        private Button btnCancelar;
        private ComboBox cmbBoxDisciplina;
        private ComboBox cmbBoxMateria;
        private Label label1;
        private Label label3;
        private RadioButton rdBtnOpcaoA;
        private RadioButton rdBtnOpcaoB;
        private RadioButton rdBtnOpcaoC;
        private RadioButton rdBtnOpcaoD;
        private TextBox txtRespostaA;
        private TextBox txtRespostaB;
        private TextBox txtRespostaC;
        private TextBox txtRespostaD;
        private TextBox txtId;
    }
}