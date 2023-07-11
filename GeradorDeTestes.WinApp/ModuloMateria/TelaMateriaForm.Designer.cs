namespace GeradorDeTestes.WinApp.ModuloMateria
{
    partial class TelaMateriaForm
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
            label3 = new Label();
            label4 = new Label();
            txtNome = new TextBox();
            rbSerie1 = new RadioButton();
            rbSerie2 = new RadioButton();
            cbxDisciplina = new ComboBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            txtId = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 41);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 75);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 2;
            label3.Text = "Disiplina";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 117);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 3;
            label4.Text = "Serie";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(79, 41);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(106, 23);
            txtNome.TabIndex = 5;
            // 
            // rbSerie1
            // 
            rbSerie1.AutoSize = true;
            rbSerie1.Location = new Point(69, 117);
            rbSerie1.Name = "rbSerie1";
            rbSerie1.Size = new Size(36, 19);
            rbSerie1.TabIndex = 6;
            rbSerie1.TabStop = true;
            rbSerie1.Text = "1ª";
            rbSerie1.UseVisualStyleBackColor = true;
            // 
            // rbSerie2
            // 
            rbSerie2.AutoSize = true;
            rbSerie2.Location = new Point(111, 117);
            rbSerie2.Name = "rbSerie2";
            rbSerie2.Size = new Size(36, 19);
            rbSerie2.TabIndex = 7;
            rbSerie2.TabStop = true;
            rbSerie2.Text = "2ª";
            rbSerie2.UseVisualStyleBackColor = true;
            // 
            // cbxDisciplina
            // 
            cbxDisciplina.FormattingEnabled = true;
            cbxDisciplina.Location = new Point(79, 72);
            cbxDisciplina.Name = "cbxDisciplina";
            cbxDisciplina.Size = new Size(108, 23);
            cbxDisciplina.TabIndex = 8;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(61, 180);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 41);
            btnGravar.TabIndex = 25;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(142, 180);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 26;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.Location = new Point(-3, 268);
            txtId.Multiline = true;
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(10, 10);
            txtId.TabIndex = 39;
            txtId.Text = "0";
            // 
            // TelaMateriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(246, 272);
            Controls.Add(txtId);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(cbxDisciplina);
            Controls.Add(rbSerie2);
            Controls.Add(rbSerie1);
            Controls.Add(txtNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "TelaMateriaForm";
            Text = "Cadastro Materia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNome;
        private RadioButton rbSerie1;
        private RadioButton rbSerie2;
        private ComboBox cbxDisciplina;
        private Button btnGravar;
        private Button btnCancelar;
        private TextBox txtId;
    }
}