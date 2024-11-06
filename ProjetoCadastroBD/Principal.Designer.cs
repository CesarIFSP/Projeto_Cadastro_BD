namespace ProjetoCadastroBD
{
    partial class Principal
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            opçõesToolStripMenuItem = new ToolStripMenuItem();
            cadastroAlunoToolStripMenuItem = new ToolStripMenuItem();
            cadastroCursoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { opçõesToolStripMenuItem });
            menuStrip1.Location = new Point(3, 64);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(794, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            opçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroAlunoToolStripMenuItem, cadastroCursoToolStripMenuItem });
            opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            opçõesToolStripMenuItem.Size = new Size(59, 20);
            opçõesToolStripMenuItem.Text = "Opções";
            // 
            // cadastroAlunoToolStripMenuItem
            // 
            cadastroAlunoToolStripMenuItem.Name = "cadastroAlunoToolStripMenuItem";
            cadastroAlunoToolStripMenuItem.Size = new Size(180, 22);
            cadastroAlunoToolStripMenuItem.Text = "Cadastro Aluno";
            cadastroAlunoToolStripMenuItem.Click += cadastroAlunoToolStripMenuItem_Click;
            // 
            // cadastroCursoToolStripMenuItem
            // 
            cadastroCursoToolStripMenuItem.Name = "cadastroCursoToolStripMenuItem";
            cadastroCursoToolStripMenuItem.Size = new Size(180, 22);
            cadastroCursoToolStripMenuItem.Text = "Cadastro Curso";
            cadastroCursoToolStripMenuItem.Click += cadastroCursoToolStripMenuItem_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.logo;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Principal";
            Text = "Cadastro de Aluno - Banco de Dados";
            WindowState = FormWindowState.Maximized;
            Load += Principal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem opçõesToolStripMenuItem;
        private ToolStripMenuItem cadastroAlunoToolStripMenuItem;
        private ToolStripMenuItem cadastroCursoToolStripMenuItem;
    }
}
