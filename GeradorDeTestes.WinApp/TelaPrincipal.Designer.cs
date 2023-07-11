namespace GeradorDeTestes.WinApp
{
    partial class TelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            menu = new MenuStrip();
            cadastrosMenuItem = new ToolStripMenuItem();
            testeMenuItem = new ToolStripMenuItem();
            materiaMenuItem = new ToolStripMenuItem();
            questaoMenuItem = new ToolStripMenuItem();
            disciplinasMenuItem = new ToolStripMenuItem();
            relatóriosToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnInserir = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            btnVisualizarItems = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            brnGerarPDF = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            lblTipoDeCadastro = new ToolStripLabel();
            panelRegistros = new Panel();
            statusStrip1 = new StatusStrip();
            labelRodape = new ToolStripStatusLabel();
            tsbDuplicar = new ToolStripButton();
            menu.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { cadastrosMenuItem, relatóriosToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(815, 24);
            menu.TabIndex = 1;
            menu.Text = "menuStrip1";
            // 
            // cadastrosMenuItem
            // 
            cadastrosMenuItem.DropDownItems.AddRange(new ToolStripItem[] { testeMenuItem, materiaMenuItem, questaoMenuItem, disciplinasMenuItem });
            cadastrosMenuItem.Name = "cadastrosMenuItem";
            cadastrosMenuItem.Size = new Size(71, 20);
            cadastrosMenuItem.Text = "Cadastros";
            // 
            // testeMenuItem
            // 
            testeMenuItem.Name = "testeMenuItem";
            testeMenuItem.ShortcutKeys = Keys.F1;
            testeMenuItem.Size = new Size(144, 22);
            testeMenuItem.Text = "Teste";
            testeMenuItem.Click += testeMenuItem_Click;
            // 
            // materiaMenuItem
            // 
            materiaMenuItem.Name = "materiaMenuItem";
            materiaMenuItem.ShortcutKeys = Keys.F2;
            materiaMenuItem.Size = new Size(144, 22);
            materiaMenuItem.Text = "Matéria";
            materiaMenuItem.Click += materiaMenuItem_Click;
            // 
            // questaoMenuItem
            // 
            questaoMenuItem.Name = "questaoMenuItem";
            questaoMenuItem.ShortcutKeys = Keys.F3;
            questaoMenuItem.Size = new Size(144, 22);
            questaoMenuItem.Text = "Questão";
            questaoMenuItem.Click += questaoMenuItem_Click;
            // 
            // disciplinasMenuItem
            // 
            disciplinasMenuItem.Name = "disciplinasMenuItem";
            disciplinasMenuItem.ShortcutKeys = Keys.F4;
            disciplinasMenuItem.Size = new Size(144, 22);
            disciplinasMenuItem.Text = "Disciplina";
            disciplinasMenuItem.Click += disciplinasMenuItem_Click;
            // 
            // relatóriosToolStripMenuItem
            // 
            relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            relatóriosToolStripMenuItem.Size = new Size(71, 20);
            relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.ImageScalingSize = new Size(50, 50);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnInserir, btnEditar, btnExcluir, btnVisualizarItems, toolStripSeparator1, brnGerarPDF, toolStripSeparator3, tsbDuplicar, lblTipoDeCadastro });
            toolStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(815, 35);
            toolStrip1.Stretch = true;
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnInserir
            // 
            btnInserir.AutoSize = false;
            btnInserir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnInserir.Image = Properties.Resources.button_iinserir;
            btnInserir.ImageTransparentColor = Color.Magenta;
            btnInserir.Margin = new Padding(10, 1, 10, 2);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(44, 36);
            btnInserir.Text = "Inserir";
            btnInserir.Click += btnInserir_Click;
            // 
            // btnEditar
            // 
            btnEditar.AutoSize = false;
            btnEditar.BackColor = SystemColors.Control;
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Margin = new Padding(10, 1, 10, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(40, 34);
            btnEditar.Text = "Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSize = false;
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Image = Properties.Resources.button_excluir;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Margin = new Padding(10, 1, 10, 2);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(35, 30);
            btnExcluir.Text = "Excluir";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnVisualizarItems
            // 
            btnVisualizarItems.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnVisualizarItems.Image = Properties.Resources.btnVisualizarItens;
            btnVisualizarItems.ImageScaling = ToolStripItemImageScaling.None;
            btnVisualizarItems.ImageTransparentColor = Color.Magenta;
            btnVisualizarItems.Name = "btnVisualizarItems";
            btnVisualizarItems.Padding = new Padding(7);
            btnVisualizarItems.Size = new Size(50, 32);
            btnVisualizarItems.Text = "toolStripButton1";
            btnVisualizarItems.Click += btnVisualizarItems_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 35);
            // 
            // brnGerarPDF
            // 
            brnGerarPDF.DisplayStyle = ToolStripItemDisplayStyle.Image;
            brnGerarPDF.Image = Properties.Resources.download_pdf__1_;
            brnGerarPDF.ImageScaling = ToolStripItemImageScaling.None;
            brnGerarPDF.ImageTransparentColor = Color.Magenta;
            brnGerarPDF.Name = "brnGerarPDF";
            brnGerarPDF.Padding = new Padding(9);
            brnGerarPDF.Size = new Size(46, 32);
            brnGerarPDF.Text = "toolStripButton1";
            brnGerarPDF.Click += brnGerarPDF_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 35);
            // 
            // lblTipoDeCadastro
            // 
            lblTipoDeCadastro.Name = "lblTipoDeCadastro";
            lblTipoDeCadastro.Size = new Size(91, 32);
            lblTipoDeCadastro.Text = "TipoDeCadastro";
            // 
            // panelRegistros
            // 
            panelRegistros.Location = new Point(0, 59);
            panelRegistros.Name = "panelRegistros";
            panelRegistros.Size = new Size(815, 338);
            panelRegistros.TabIndex = 4;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { labelRodape });
            statusStrip1.Location = new Point(0, 400);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(815, 22);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // labelRodape
            // 
            labelRodape.Name = "labelRodape";
            labelRodape.Size = new Size(52, 17);
            labelRodape.Text = "[rodapé]";
            // 
            // tsbDuplicar
            // 
            tsbDuplicar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbDuplicar.Image = (Image)resources.GetObject("tsbDuplicar.Image");
            tsbDuplicar.ImageTransparentColor = Color.Magenta;
            tsbDuplicar.Name = "tsbDuplicar";
            tsbDuplicar.Size = new Size(54, 32);
            tsbDuplicar.Text = "toolStripButton1";
            tsbDuplicar.Click += tsbDuplicar_Click;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(815, 422);
            Controls.Add(statusStrip1);
            Controls.Add(panelRegistros);
            Controls.Add(toolStrip1);
            Controls.Add(menu);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaPrincipal";
            ShowIcon = false;
            Text = "Gerador de Testes";
            menu.ResumeLayout(false);
            menu.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private ToolStripMenuItem cadastrosMenuItem;
        private ToolStripMenuItem testeMenuItem;
        private ToolStripMenuItem materiaMenuItem;
        private ToolStripMenuItem questaoMenuItem;
        private ToolStripMenuItem disciplinasMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton btnInserir;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private Panel panelRegistros;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStripLabel lblTipoDeCadastro;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel labelRodape;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnVisualizarItems;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton brnGerarPDF;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton tsbDuplicar;
    }
}