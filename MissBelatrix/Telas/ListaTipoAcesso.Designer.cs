namespace MissBelatrix.Telas
{
    partial class ListaTipoAcesso
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
            this.btExcluir = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.lbFiltrar = new System.Windows.Forms.Label();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.grvTipoAcesso = new System.Windows.Forms.DataGridView();
            this.clCheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CdTipoAcesso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DsTipoAcesso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvTipoAcesso)).BeginInit();
            this.SuspendLayout();
            // 
            // btExcluir
            // 
            this.btExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.Location = new System.Drawing.Point(12, 121);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(83, 32);
            this.btExcluir.TabIndex = 22;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // btEditar
            // 
            this.btEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.Location = new System.Drawing.Point(12, 83);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(83, 32);
            this.btEditar.TabIndex = 21;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Location = new System.Drawing.Point(12, 45);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(83, 32);
            this.btCadastrar.TabIndex = 20;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // lbFiltrar
            // 
            this.lbFiltrar.AutoSize = true;
            this.lbFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltrar.Location = new System.Drawing.Point(112, 17);
            this.lbFiltrar.Name = "lbFiltrar";
            this.lbFiltrar.Size = new System.Drawing.Size(49, 18);
            this.lbFiltrar.TabIndex = 19;
            this.lbFiltrar.Text = "Filtrar:";
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrar.Location = new System.Drawing.Point(167, 14);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(621, 24);
            this.txtFiltrar.TabIndex = 18;
            // 
            // grvTipoAcesso
            // 
            this.grvTipoAcesso.AllowUserToAddRows = false;
            this.grvTipoAcesso.AllowUserToDeleteRows = false;
            this.grvTipoAcesso.AllowUserToResizeColumns = false;
            this.grvTipoAcesso.AllowUserToResizeRows = false;
            this.grvTipoAcesso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvTipoAcesso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCheckBox,
            this.CdTipoAcesso,
            this.DsTipoAcesso});
            this.grvTipoAcesso.Location = new System.Drawing.Point(115, 45);
            this.grvTipoAcesso.MultiSelect = false;
            this.grvTipoAcesso.Name = "grvTipoAcesso";
            this.grvTipoAcesso.RowHeadersVisible = false;
            this.grvTipoAcesso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvTipoAcesso.Size = new System.Drawing.Size(673, 392);
            this.grvTipoAcesso.TabIndex = 17;
            // 
            // clCheckBox
            // 
            this.clCheckBox.HeaderText = "";
            this.clCheckBox.Name = "clCheckBox";
            this.clCheckBox.ReadOnly = true;
            // 
            // CdTipoAcesso
            // 
            this.CdTipoAcesso.DataPropertyName = "CdTipoAcesso";
            this.CdTipoAcesso.HeaderText = "Código";
            this.CdTipoAcesso.Name = "CdTipoAcesso";
            this.CdTipoAcesso.ReadOnly = true;
            // 
            // DsTipoAcesso
            // 
            this.DsTipoAcesso.DataPropertyName = "DsTipoAcesso";
            this.DsTipoAcesso.HeaderText = "Tipo Acesso";
            this.DsTipoAcesso.Name = "DsTipoAcesso";
            this.DsTipoAcesso.ReadOnly = true;
            // 
            // ListaTipoAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.lbFiltrar);
            this.Controls.Add(this.txtFiltrar);
            this.Controls.Add(this.grvTipoAcesso);
            this.Name = "ListaTipoAcesso";
            this.Text = "ListaTipoAcesso";
            this.Load += new System.EventHandler(this.ListaTipoAcesso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvTipoAcesso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Label lbFiltrar;
        private System.Windows.Forms.TextBox txtFiltrar;
        public System.Windows.Forms.DataGridView grvTipoAcesso;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdTipoAcesso;
        private System.Windows.Forms.DataGridViewTextBoxColumn DsTipoAcesso;
    }
}