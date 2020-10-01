namespace MissBelatrix.Telas
{
    partial class ListaProdutos
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
            this.lbFiltrar = new System.Windows.Forms.Label();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.grvListaProdutos = new System.Windows.Forms.DataGridView();
            this.clCheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DsProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdTipoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdTamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdCor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VlPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvListaProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFiltrar
            // 
            this.lbFiltrar.AutoSize = true;
            this.lbFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltrar.Location = new System.Drawing.Point(112, 17);
            this.lbFiltrar.Name = "lbFiltrar";
            this.lbFiltrar.Size = new System.Drawing.Size(49, 18);
            this.lbFiltrar.TabIndex = 11;
            this.lbFiltrar.Text = "Filtrar:";
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrar.Location = new System.Drawing.Point(167, 14);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(621, 24);
            this.txtFiltrar.TabIndex = 10;
            // 
            // btExcluir
            // 
            this.btExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.Location = new System.Drawing.Point(12, 121);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(83, 32);
            this.btExcluir.TabIndex = 9;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btEditar
            // 
            this.btEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.Location = new System.Drawing.Point(12, 83);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(83, 32);
            this.btEditar.TabIndex = 8;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Location = new System.Drawing.Point(12, 45);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(83, 32);
            this.btCadastrar.TabIndex = 7;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // grvListaProdutos
            // 
            this.grvListaProdutos.AllowUserToAddRows = false;
            this.grvListaProdutos.AllowUserToDeleteRows = false;
            this.grvListaProdutos.AllowUserToResizeColumns = false;
            this.grvListaProdutos.AllowUserToResizeRows = false;
            this.grvListaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvListaProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCheckBox,
            this.CdProduto,
            this.DsProduto,
            this.CdTipoProduto,
            this.CdTamanho,
            this.CdCor,
            this.VlPreco});
            this.grvListaProdutos.Location = new System.Drawing.Point(115, 45);
            this.grvListaProdutos.MultiSelect = false;
            this.grvListaProdutos.Name = "grvListaProdutos";
            this.grvListaProdutos.RowHeadersVisible = false;
            this.grvListaProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvListaProdutos.Size = new System.Drawing.Size(673, 392);
            this.grvListaProdutos.TabIndex = 6;
            this.grvListaProdutos.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grvListaProdutos_CellMouseDown);
            // 
            // clCheckBox
            // 
            this.clCheckBox.HeaderText = "";
            this.clCheckBox.Name = "clCheckBox";
            this.clCheckBox.ReadOnly = true;
            this.clCheckBox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clCheckBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CdProduto
            // 
            this.CdProduto.DataPropertyName = "CdProduto";
            this.CdProduto.HeaderText = "Código";
            this.CdProduto.Name = "CdProduto";
            this.CdProduto.ReadOnly = true;
            // 
            // DsProduto
            // 
            this.DsProduto.DataPropertyName = "DsProduto";
            this.DsProduto.HeaderText = "Produto";
            this.DsProduto.Name = "DsProduto";
            this.DsProduto.ReadOnly = true;
            // 
            // CdTipoProduto
            // 
            this.CdTipoProduto.DataPropertyName = "CdTipoProduto";
            this.CdTipoProduto.HeaderText = "Tipo do Produto";
            this.CdTipoProduto.Name = "CdTipoProduto";
            this.CdTipoProduto.ReadOnly = true;
            // 
            // CdTamanho
            // 
            this.CdTamanho.DataPropertyName = "CdTamanho";
            this.CdTamanho.HeaderText = "Tamanho";
            this.CdTamanho.Name = "CdTamanho";
            this.CdTamanho.ReadOnly = true;
            // 
            // CdCor
            // 
            this.CdCor.DataPropertyName = "CdCor";
            this.CdCor.HeaderText = "Cor";
            this.CdCor.Name = "CdCor";
            this.CdCor.ReadOnly = true;
            // 
            // VlPreco
            // 
            this.VlPreco.DataPropertyName = "VlPreco";
            this.VlPreco.HeaderText = "Preço";
            this.VlPreco.Name = "VlPreco";
            this.VlPreco.ReadOnly = true;
            // 
            // ListaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbFiltrar);
            this.Controls.Add(this.txtFiltrar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.grvListaProdutos);
            this.Name = "ListaProdutos";
            this.Text = "ListaProdutos";
            this.Load += new System.EventHandler(this.ListaProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvListaProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFiltrar;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btCadastrar;
        public System.Windows.Forms.DataGridView grvListaProdutos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DsProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdTipoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdTamanho;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdCor;
        private System.Windows.Forms.DataGridViewTextBoxColumn VlPreco;
    }
}