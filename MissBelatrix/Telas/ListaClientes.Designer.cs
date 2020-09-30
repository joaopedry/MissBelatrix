namespace MissBelatrix.Telas
{
    partial class ListaClientes
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
            this.grvListaClientes = new System.Windows.Forms.DataGridView();
            this.clCheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CdTipoAcesso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DsCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DsEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DsFone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.lbFiltrar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvListaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // grvListaClientes
            // 
            this.grvListaClientes.AllowUserToAddRows = false;
            this.grvListaClientes.AllowUserToDeleteRows = false;
            this.grvListaClientes.AllowUserToResizeColumns = false;
            this.grvListaClientes.AllowUserToResizeRows = false;
            this.grvListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvListaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCheckBox,
            this.CdTipoAcesso,
            this.CdCliente,
            this.DsCliente,
            this.DsEmail,
            this.DsFone,
            this.IdGenero});
            this.grvListaClientes.Location = new System.Drawing.Point(115, 45);
            this.grvListaClientes.MultiSelect = false;
            this.grvListaClientes.Name = "grvListaClientes";
            this.grvListaClientes.RowHeadersVisible = false;
            this.grvListaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvListaClientes.Size = new System.Drawing.Size(673, 392);
            this.grvListaClientes.TabIndex = 0;
            this.grvListaClientes.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grvListaClientes_CellMouseDown);
            // 
            // clCheckBox
            // 
            this.clCheckBox.HeaderText = "";
            this.clCheckBox.Name = "clCheckBox";
            this.clCheckBox.ReadOnly = true;
            this.clCheckBox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CdTipoAcesso
            // 
            this.CdTipoAcesso.DataPropertyName = "CdTipoAcesso";
            this.CdTipoAcesso.HeaderText = "Tipo de Acesso";
            this.CdTipoAcesso.Name = "CdTipoAcesso";
            this.CdTipoAcesso.ReadOnly = true;
            // 
            // CdCliente
            // 
            this.CdCliente.DataPropertyName = "CdCliente";
            this.CdCliente.HeaderText = "Código";
            this.CdCliente.Name = "CdCliente";
            this.CdCliente.ReadOnly = true;
            // 
            // DsCliente
            // 
            this.DsCliente.DataPropertyName = "DsCliente";
            this.DsCliente.HeaderText = "Cliente";
            this.DsCliente.Name = "DsCliente";
            this.DsCliente.ReadOnly = true;
            // 
            // DsEmail
            // 
            this.DsEmail.DataPropertyName = "DsEmail";
            this.DsEmail.HeaderText = "E-mail";
            this.DsEmail.Name = "DsEmail";
            this.DsEmail.ReadOnly = true;
            // 
            // DsFone
            // 
            this.DsFone.DataPropertyName = "DsFone";
            this.DsFone.HeaderText = "Telefone";
            this.DsFone.Name = "DsFone";
            this.DsFone.ReadOnly = true;
            // 
            // IdGenero
            // 
            this.IdGenero.DataPropertyName = "IdGenero";
            this.IdGenero.HeaderText = "Gênero";
            this.IdGenero.Name = "IdGenero";
            this.IdGenero.ReadOnly = true;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Location = new System.Drawing.Point(12, 45);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(83, 32);
            this.btCadastrar.TabIndex = 1;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btEditar
            // 
            this.btEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.Location = new System.Drawing.Point(12, 83);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(83, 32);
            this.btEditar.TabIndex = 2;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.Location = new System.Drawing.Point(12, 121);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(83, 32);
            this.btExcluir.TabIndex = 3;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrar.Location = new System.Drawing.Point(167, 14);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(621, 24);
            this.txtFiltrar.TabIndex = 4;
            // 
            // lbFiltrar
            // 
            this.lbFiltrar.AutoSize = true;
            this.lbFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltrar.Location = new System.Drawing.Point(112, 17);
            this.lbFiltrar.Name = "lbFiltrar";
            this.lbFiltrar.Size = new System.Drawing.Size(49, 18);
            this.lbFiltrar.TabIndex = 5;
            this.lbFiltrar.Text = "Filtrar:";
            // 
            // ListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbFiltrar);
            this.Controls.Add(this.txtFiltrar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.grvListaClientes);
            this.Name = "ListaClientes";
            this.Text = "ListaClientes";
            this.Load += new System.EventHandler(this.ListaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvListaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.Label lbFiltrar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdTipoAcesso;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DsCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DsEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn DsFone;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGenero;
        public System.Windows.Forms.DataGridView grvListaClientes;
    }
}