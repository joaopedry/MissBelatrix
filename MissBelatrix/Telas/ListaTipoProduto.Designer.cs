namespace MissBelatrix.Telas
{
    partial class ListaTipoProduto
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
            this.grvListaTipoProdutos = new System.Windows.Forms.DataGridView();
            this.clCheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CdTipoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DsTipoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvListaTipoProdutos)).BeginInit();
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
            // grvListaTipoProdutos
            // 
            this.grvListaTipoProdutos.AllowUserToAddRows = false;
            this.grvListaTipoProdutos.AllowUserToDeleteRows = false;
            this.grvListaTipoProdutos.AllowUserToResizeColumns = false;
            this.grvListaTipoProdutos.AllowUserToResizeRows = false;
            this.grvListaTipoProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvListaTipoProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCheckBox,
            this.CdTipoProduto,
            this.DsTipoProduto});
            this.grvListaTipoProdutos.Location = new System.Drawing.Point(115, 45);
            this.grvListaTipoProdutos.MultiSelect = false;
            this.grvListaTipoProdutos.Name = "grvListaTipoProdutos";
            this.grvListaTipoProdutos.RowHeadersVisible = false;
            this.grvListaTipoProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvListaTipoProdutos.Size = new System.Drawing.Size(673, 392);
            this.grvListaTipoProdutos.TabIndex = 6;
            this.grvListaTipoProdutos.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grvListaTipoProdutos_CellMouseDown);
            // 
            // clCheckBox
            // 
            this.clCheckBox.HeaderText = "";
            this.clCheckBox.Name = "clCheckBox";
            this.clCheckBox.ReadOnly = true;
            // 
            // CdTipoProduto
            // 
            this.CdTipoProduto.DataPropertyName = "CdTipoProduto";
            this.CdTipoProduto.HeaderText = "Código";
            this.CdTipoProduto.Name = "CdTipoProduto";
            this.CdTipoProduto.ReadOnly = true;
            // 
            // DsTipoProduto
            // 
            this.DsTipoProduto.DataPropertyName = "DsTipoProduto";
            this.DsTipoProduto.HeaderText = "Tipo Produto";
            this.DsTipoProduto.Name = "DsTipoProduto";
            this.DsTipoProduto.ReadOnly = true;
            // 
            // ListaTipoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbFiltrar);
            this.Controls.Add(this.txtFiltrar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.grvListaTipoProdutos);
            this.Name = "ListaTipoProduto";
            this.Text = "ListaTipoProduto";
            this.Load += new System.EventHandler(this.ListaTipoProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvListaTipoProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFiltrar;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btCadastrar;
        public System.Windows.Forms.DataGridView grvListaTipoProdutos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdTipoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DsTipoProduto;
    }
}