namespace GeradorDeTestes.WinApp.ModuloTeste
{
    partial class TelaVisualizarQuestoesForm
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
            lblTituloProva = new Label();
            listQuestoes = new ListBox();
            SuspendLayout();
            // 
            // lblTituloProva
            // 
            lblTituloProva.AutoSize = true;
            lblTituloProva.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblTituloProva.Location = new Point(137, 30);
            lblTituloProva.Name = "lblTituloProva";
            lblTituloProva.Size = new Size(123, 30);
            lblTituloProva.TabIndex = 3;
            lblTituloProva.Text = "TituloProva";
            // 
            // listQuestoes
            // 
            listQuestoes.FormattingEnabled = true;
            listQuestoes.ItemHeight = 15;
            listQuestoes.Location = new Point(12, 83);
            listQuestoes.Name = "listQuestoes";
            listQuestoes.Size = new Size(382, 394);
            listQuestoes.TabIndex = 4;
            // 
            // TelaVisualizarQuestoesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 491);
            Controls.Add(listQuestoes);
            Controls.Add(lblTituloProva);
            Name = "TelaVisualizarQuestoesForm";
            Text = "Visualizar Questoes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloProva;
        private ListBox listQuestoes;
    }
}