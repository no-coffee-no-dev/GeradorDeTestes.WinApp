namespace GeradorDeTestes.WinApp.ModuloDisciplina
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
            listRespostas = new ListBox();
            lblTituloPergunta = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(listRespostas);
            panel1.Location = new Point(14, 56);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(458, 528);
            panel1.TabIndex = 1;
            // 
            // listRespostas
            // 
            listRespostas.Dock = DockStyle.Fill;
            listRespostas.FormattingEnabled = true;
            listRespostas.ItemHeight = 20;
            listRespostas.Location = new Point(0, 0);
            listRespostas.Margin = new Padding(3, 4, 3, 4);
            listRespostas.Name = "listRespostas";
            listRespostas.Size = new Size(458, 528);
            listRespostas.TabIndex = 0;
            // 
            // lblTituloPergunta
            // 
            lblTituloPergunta.AutoSize = true;
            lblTituloPergunta.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblTituloPergunta.Location = new Point(171, 12);
            lblTituloPergunta.Name = "lblTituloPergunta";
            lblTituloPergunta.Size = new Size(128, 37);
            lblTituloPergunta.TabIndex = 2;
            lblTituloPergunta.Text = "Pergunta";
            // 
            // TelaVisualizarItemsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 600);
            Controls.Add(lblTituloPergunta);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaVisualizarItemsForm";
            Text = "Questões Relacionadas a Disciplina";
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