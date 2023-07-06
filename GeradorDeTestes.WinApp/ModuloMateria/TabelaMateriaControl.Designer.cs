namespace GeradorDeTestes.WinApp.ModuloMateria
{
    partial class TabelaMateriaControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabelaMateria = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tabelaMateria).BeginInit();
            SuspendLayout();
            // 
            // tabelaMateria
            // 
            tabelaMateria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaMateria.Location = new Point(10, 3);
            tabelaMateria.Name = "tabelaMateria";
            tabelaMateria.RowTemplate.Height = 25;
            tabelaMateria.Size = new Size(140, 150);
            tabelaMateria.TabIndex = 0;
            // 
            // TabelaMateriaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabelaMateria);
            Name = "TabelaMateriaControl";
            ((System.ComponentModel.ISupportInitialize)tabelaMateria).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tabelaMateria;
    }
}
