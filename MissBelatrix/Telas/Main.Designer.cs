namespace MissBelatrix.Telas
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTipoAcessos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTipoProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTamanhos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCores = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.caixaToolStripMenuItem,
            this.menuSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClientes,
            this.menuProdutos,
            this.menuTipoAcessos,
            this.menuTipoProdutos,
            this.menuTamanhos,
            this.menuCores});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.produtosToolStripMenuItem.Text = "Gerenciamento";
            // 
            // menuClientes
            // 
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(169, 22);
            this.menuClientes.Text = "Clientes";
            this.menuClientes.Click += new System.EventHandler(this.menuClientes_Click);
            // 
            // menuProdutos
            // 
            this.menuProdutos.Name = "menuProdutos";
            this.menuProdutos.Size = new System.Drawing.Size(169, 22);
            this.menuProdutos.Text = "Produtos";
            this.menuProdutos.Click += new System.EventHandler(this.menuProdutos_Click);
            // 
            // menuTipoAcessos
            // 
            this.menuTipoAcessos.Name = "menuTipoAcessos";
            this.menuTipoAcessos.Size = new System.Drawing.Size(169, 22);
            this.menuTipoAcessos.Text = "Tipos de Acesso";
            this.menuTipoAcessos.Click += new System.EventHandler(this.menuTipoAcessos_Click);
            // 
            // menuTipoProdutos
            // 
            this.menuTipoProdutos.Name = "menuTipoProdutos";
            this.menuTipoProdutos.Size = new System.Drawing.Size(169, 22);
            this.menuTipoProdutos.Text = "Tipos de Produtos";
            this.menuTipoProdutos.Click += new System.EventHandler(this.menuTipoProdutos_Click);
            // 
            // menuTamanhos
            // 
            this.menuTamanhos.Name = "menuTamanhos";
            this.menuTamanhos.Size = new System.Drawing.Size(169, 22);
            this.menuTamanhos.Text = "Tamanhos";
            this.menuTamanhos.Click += new System.EventHandler(this.menuTamanhos_Click);
            // 
            // menuCores
            // 
            this.menuCores.Name = "menuCores";
            this.menuCores.Size = new System.Drawing.Size(169, 22);
            this.menuCores.Text = "Cores";
            this.menuCores.Click += new System.EventHandler(this.menuCores_Click);
            // 
            // caixaToolStripMenuItem
            // 
            this.caixaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradasToolStripMenuItem,
            this.saidasToolStripMenuItem});
            this.caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            this.caixaToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.caixaToolStripMenuItem.Text = "Caixa";
            // 
            // entradasToolStripMenuItem
            // 
            this.entradasToolStripMenuItem.Name = "entradasToolStripMenuItem";
            this.entradasToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.entradasToolStripMenuItem.Text = "Entradas";
            // 
            // saidasToolStripMenuItem
            // 
            this.saidasToolStripMenuItem.Name = "saidasToolStripMenuItem";
            this.saidasToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.saidasToolStripMenuItem.Text = "Saidas";
            // 
            // menuSair
            // 
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(38, 20);
            this.menuSair.Text = "Sair";
            this.menuSair.Click += new System.EventHandler(this.menuSair_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuProdutos;
        private System.Windows.Forms.ToolStripMenuItem menuClientes;
        private System.Windows.Forms.ToolStripMenuItem caixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.ToolStripMenuItem menuTipoProdutos;
        private System.Windows.Forms.ToolStripMenuItem menuCores;
        private System.Windows.Forms.ToolStripMenuItem menuTamanhos;
        private System.Windows.Forms.ToolStripMenuItem menuTipoAcessos;
    }
}