namespace GeradorDeTestes.WinApp.ModuloDisciplina
{
    partial class TabelaDisciplinaControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabelaDisciplina = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tabelaDisciplina).BeginInit();
            SuspendLayout();
            // 
            // tabelaDisciplina
            // 
            tabelaDisciplina.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaDisciplina.Location = new Point(167, 85);
            tabelaDisciplina.Name = "tabelaDisciplina";
            tabelaDisciplina.RowTemplate.Height = 25;
            tabelaDisciplina.Size = new Size(240, 150);
            tabelaDisciplina.TabIndex = 0;
            // 
            // TabelaDisciplinaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabelaDisciplina);
            Name = "TabelaDisciplinaControl";
            Size = new Size(760, 418);
            ((System.ComponentModel.ISupportInitialize)tabelaDisciplina).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tabelaDisciplina;
    }
}