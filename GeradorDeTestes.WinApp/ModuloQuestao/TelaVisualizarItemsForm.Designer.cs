namespace GeradorDeTestes.WinApp.ModuloQuestao
{
    partial class TelaVisualizarItemsForm
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
            panel1 = new Panel();
            lblTituloPergunta = new Label();
            listRespostas = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(listRespostas);
            panel1.Location = new Point(12, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(401, 396);
            panel1.TabIndex = 1;
            // 
            // lblTituloPergunta
            // 
            lblTituloPergunta.AutoSize = true;
            lblTituloPergunta.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblTituloPergunta.Location = new Point(150, 9);
            lblTituloPergunta.Name = "lblTituloPergunta";
            lblTituloPergunta.Size = new Size(100, 30);
            lblTituloPergunta.TabIndex = 2;
            lblTituloPergunta.Text = "Pergunta";
            // 
            // listRespostas
            // 
            listRespostas.Dock = DockStyle.Fill;
            listRespostas.FormattingEnabled = true;
            listRespostas.ItemHeight = 15;
            listRespostas.Location = new Point(0, 0);
            listRespostas.Name = "listRespostas";
            listRespostas.Size = new Size(401, 396);
            listRespostas.TabIndex = 0;
            // 
            // TelaVisualizarItemsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 450);
            Controls.Add(lblTituloPergunta);
            Controls.Add(panel1);
            Name = "TelaVisualizarItemsForm";
            Text = "Visualizar Respostas";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label lblTituloPergunta;
        private ListBox listRespostas;
    }
}