
namespace Projeto_Chamada
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarPalestrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frequênciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.frequênciaToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarAlunosToolStripMenuItem,
            this.cadastrarPalestrasToolStripMenuItem,
            this.atualizarAlunosToolStripMenuItem,
            this.excluirAlunosToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // cadastrarAlunosToolStripMenuItem
            // 
            this.cadastrarAlunosToolStripMenuItem.Name = "cadastrarAlunosToolStripMenuItem";
            this.cadastrarAlunosToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.cadastrarAlunosToolStripMenuItem.Text = "Cadastrar Alunos";
            this.cadastrarAlunosToolStripMenuItem.Click += new System.EventHandler(this.cadastrarAlunosToolStripMenuItem_Click);
            // 
            // cadastrarPalestrasToolStripMenuItem
            // 
            this.cadastrarPalestrasToolStripMenuItem.Name = "cadastrarPalestrasToolStripMenuItem";
            this.cadastrarPalestrasToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.cadastrarPalestrasToolStripMenuItem.Text = "Cadastrar Palestras";
            this.cadastrarPalestrasToolStripMenuItem.Click += new System.EventHandler(this.cadastrarPalestrasToolStripMenuItem_Click);
            // 
            // atualizarAlunosToolStripMenuItem
            // 
            this.atualizarAlunosToolStripMenuItem.Name = "atualizarAlunosToolStripMenuItem";
            this.atualizarAlunosToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.atualizarAlunosToolStripMenuItem.Text = "Atualizar Alunos";
            this.atualizarAlunosToolStripMenuItem.Click += new System.EventHandler(this.atualizarAlunosToolStripMenuItem_Click);
            // 
            // excluirAlunosToolStripMenuItem
            // 
            this.excluirAlunosToolStripMenuItem.Name = "excluirAlunosToolStripMenuItem";
            this.excluirAlunosToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.excluirAlunosToolStripMenuItem.Text = "Excluir Alunos";
            this.excluirAlunosToolStripMenuItem.Click += new System.EventHandler(this.excluirAlunosToolStripMenuItem_Click);
            // 
            // frequênciaToolStripMenuItem
            // 
            this.frequênciaToolStripMenuItem.Name = "frequênciaToolStripMenuItem";
            this.frequênciaToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.frequênciaToolStripMenuItem.Text = "Frequência";
            this.frequênciaToolStripMenuItem.Click += new System.EventHandler(this.frequênciaToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            this.relatóriosToolStripMenuItem.Click += new System.EventHandler(this.relatóriosToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Controle de Presença";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarAlunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarPalestrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frequênciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarAlunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirAlunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
    }
}

