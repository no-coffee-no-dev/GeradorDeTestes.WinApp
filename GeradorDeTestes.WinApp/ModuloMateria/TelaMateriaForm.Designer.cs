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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            txtNome = new TextBox();
            rbSerie1 = new RadioButton();
            rbSerie2 = new RadioButton();
            cbxDisiplina = new ComboBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 44);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 75);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 116);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 2;
            label3.Text = "Disiplina";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 159);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 3;
            label4.Text = "Serie";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(79, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(51, 23);
            textBox1.TabIndex = 4;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(79, 75);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(106, 23);
            txtNome.TabIndex = 5;
            // 
            // rbSerie1
            // 
            rbSerie1.AutoSize = true;
            rbSerie1.Location = new Point(60, 159);
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
            rbSerie2.Location = new Point(102, 159);
            rbSerie2.Name = "rbSerie2";
            rbSerie2.Size = new Size(36, 19);
            rbSerie2.TabIndex = 7;
            rbSerie2.TabStop = true;
            rbSerie2.Text = "2ª";
            rbSerie2.UseVisualStyleBackColor = true;
            // 
            // cbxDisiplina
            // 
            cbxDisiplina.FormattingEnabled = true;
            cbxDisiplina.Location = new Point(77, 108);
            cbxDisiplina.Name = "cbxDisiplina";
            cbxDisiplina.Size = new Size(108, 23);
            cbxDisiplina.TabIndex = 8;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(79, 224);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 41);
            btnGravar.TabIndex = 25;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(160, 224);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 26;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaMateriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 277);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(cbxDisiplina);
            Controls.Add(rbSerie2);
            Controls.Add(rbSerie1);
            Controls.Add(txtNome);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaMateriaForm";
            Text = "Cadastro Materia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox txtNome;
        private RadioButton rbSerie1;
        private RadioButton rbSerie2;
        private ComboBox cbxDisiplina;
        private Button btnGravar;
        private Button btnCancelar;
    }
}