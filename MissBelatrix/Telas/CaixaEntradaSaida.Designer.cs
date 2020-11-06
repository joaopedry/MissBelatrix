namespace MissBelatrix.Telas
{
    partial class CaixaEntradaSaida
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbData = new System.Windows.Forms.Label();
            this.grvCaixaEntradaSaida = new System.Windows.Forms.DataGridView();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.rbEntrada = new System.Windows.Forms.RadioButton();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lbProduto = new System.Windows.Forms.Label();
            this.rbSaida = new System.Windows.Forms.RadioButton();
            this.grpOperacao = new System.Windows.Forms.GroupBox();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lbDescricaoSaldo = new System.Windows.Forms.Label();
            this.lbSaldo = new System.Windows.Forms.Label();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.lbCliente = new System.Windows.Forms.Label();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lbValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.CdRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StTipoOperacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DsDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VlQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VlValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtOperacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvCaixaEntradaSaida)).BeginInit();
            this.grpOperacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbData.Location = new System.Drawing.Point(25, 58);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(37, 16);
            this.lbData.TabIndex = 0;
            this.lbData.Text = "Data";
            // 
            // grvCaixaEntradaSaida
            // 
            this.grvCaixaEntradaSaida.AllowUserToAddRows = false;
            this.grvCaixaEntradaSaida.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grvCaixaEntradaSaida.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.grvCaixaEntradaSaida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grvCaixaEntradaSaida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCaixaEntradaSaida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CdRegistro,
            this.StTipoOperacao,
            this.DsDescricao,
            this.VlQuantidade,
            this.VlValor,
            this.DtOperacao,
            this.DtRegistro,
            this.CdProduto,
            this.CdCliente});
            this.grvCaixaEntradaSaida.Location = new System.Drawing.Point(28, 159);
            this.grvCaixaEntradaSaida.Name = "grvCaixaEntradaSaida";
            this.grvCaixaEntradaSaida.ReadOnly = true;
            this.grvCaixaEntradaSaida.RowHeadersVisible = false;
            this.grvCaixaEntradaSaida.Size = new System.Drawing.Size(823, 246);
            this.grvCaixaEntradaSaida.TabIndex = 2;
            this.grvCaixaEntradaSaida.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvCaixaEntradaSaida_CellDoubleClick);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnRegistrar.Location = new System.Drawing.Point(775, 108);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(76, 36);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // rbEntrada
            // 
            this.rbEntrada.AutoSize = true;
            this.rbEntrada.Checked = true;
            this.rbEntrada.Location = new System.Drawing.Point(16, 19);
            this.rbEntrada.Name = "rbEntrada";
            this.rbEntrada.Size = new System.Drawing.Size(73, 20);
            this.rbEntrada.TabIndex = 4;
            this.rbEntrada.TabStop = true;
            this.rbEntrada.Text = "Entrada";
            this.rbEntrada.UseVisualStyleBackColor = true;
            this.rbEntrada.CheckedChanged += new System.EventHandler(this.rbEntrada_CheckedChanged);
            // 
            // dtpData
            // 
            this.dtpData.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(28, 78);
            this.dtpData.MaximumSize = new System.Drawing.Size(105, 24);
            this.dtpData.MinimumSize = new System.Drawing.Size(105, 24);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(105, 24);
            this.dtpData.TabIndex = 6;
            // 
            // lbProduto
            // 
            this.lbProduto.AutoSize = true;
            this.lbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbProduto.Location = new System.Drawing.Point(414, 58);
            this.lbProduto.Name = "lbProduto";
            this.lbProduto.Size = new System.Drawing.Size(55, 16);
            this.lbProduto.TabIndex = 7;
            this.lbProduto.Text = "Produto";
            // 
            // rbSaida
            // 
            this.rbSaida.AutoSize = true;
            this.rbSaida.Location = new System.Drawing.Point(107, 19);
            this.rbSaida.Name = "rbSaida";
            this.rbSaida.Size = new System.Drawing.Size(62, 20);
            this.rbSaida.TabIndex = 8;
            this.rbSaida.Text = "Saída";
            this.rbSaida.UseVisualStyleBackColor = true;
            this.rbSaida.CheckedChanged += new System.EventHandler(this.rbSaida_CheckedChanged);
            // 
            // grpOperacao
            // 
            this.grpOperacao.Controls.Add(this.rbEntrada);
            this.grpOperacao.Controls.Add(this.rbSaida);
            this.grpOperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.grpOperacao.Location = new System.Drawing.Point(12, 9);
            this.grpOperacao.Name = "grpOperacao";
            this.grpOperacao.Size = new System.Drawing.Size(213, 48);
            this.grpOperacao.TabIndex = 9;
            this.grpOperacao.TabStop = false;
            this.grpOperacao.Text = "Tipo de Operação";
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbQuantidade.Location = new System.Drawing.Point(685, 58);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(81, 16);
            this.lbQuantidade.TabIndex = 11;
            this.lbQuantidade.Text = "Quantidade:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(688, 78);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(163, 24);
            this.txtQuantidade.TabIndex = 10;
            // 
            // lbDescricaoSaldo
            // 
            this.lbDescricaoSaldo.AutoSize = true;
            this.lbDescricaoSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbDescricaoSaldo.Location = new System.Drawing.Point(756, 425);
            this.lbDescricaoSaldo.Name = "lbDescricaoSaldo";
            this.lbDescricaoSaldo.Size = new System.Drawing.Size(44, 16);
            this.lbDescricaoSaldo.TabIndex = 12;
            this.lbDescricaoSaldo.Text = "Saldo";
            // 
            // lbSaldo
            // 
            this.lbSaldo.AutoSize = true;
            this.lbSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbSaldo.Location = new System.Drawing.Point(827, 425);
            this.lbSaldo.Name = "lbSaldo";
            this.lbSaldo.Size = new System.Drawing.Size(12, 16);
            this.lbSaldo.TabIndex = 13;
            this.lbSaldo.Text = "-";
            // 
            // cbFiltro
            // 
            this.cbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Location = new System.Drawing.Point(62, 417);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(121, 24);
            this.cbFiltro.TabIndex = 14;
            this.cbFiltro.SelectionChangeCommitted += new System.EventHandler(this.cbFiltro_SelectionChangeCommitted);
            // 
            // lbFiltro
            // 
            this.lbFiltro.AutoSize = true;
            this.lbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbFiltro.Location = new System.Drawing.Point(21, 419);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(40, 16);
            this.lbFiltro.TabIndex = 15;
            this.lbFiltro.Text = "Filtro:";
            // 
            // cbProduto
            // 
            this.cbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(417, 78);
            this.cbProduto.MaximumSize = new System.Drawing.Size(260, 0);
            this.cbProduto.MinimumSize = new System.Drawing.Size(260, 0);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(260, 24);
            this.cbProduto.TabIndex = 16;
            // 
            // cbCliente
            // 
            this.cbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(145, 78);
            this.cbCliente.MaximumSize = new System.Drawing.Size(260, 0);
            this.cbCliente.MinimumSize = new System.Drawing.Size(260, 0);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(260, 24);
            this.cbCliente.TabIndex = 18;
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbCliente.Location = new System.Drawing.Point(142, 58);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(52, 16);
            this.lbCliente.TabIndex = 17;
            this.lbCliente.Text = "Cliente:";
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Enabled = false;
            this.lbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbDescricao.Location = new System.Drawing.Point(142, 58);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(73, 16);
            this.lbDescricao.TabIndex = 22;
            this.lbDescricao.Text = "Descrição:";
            this.lbDescricao.Visible = false;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(145, 78);
            this.txtDescricao.MaximumSize = new System.Drawing.Size(260, 24);
            this.txtDescricao.MinimumSize = new System.Drawing.Size(260, 24);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(260, 24);
            this.txtDescricao.TabIndex = 21;
            this.txtDescricao.Visible = false;
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Enabled = false;
            this.lbValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbValor.Location = new System.Drawing.Point(414, 58);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(43, 16);
            this.lbValor.TabIndex = 24;
            this.lbValor.Text = "Valor:";
            this.lbValor.Visible = false;
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(417, 78);
            this.txtValor.MaximumSize = new System.Drawing.Size(260, 24);
            this.txtValor.MinimumSize = new System.Drawing.Size(260, 24);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(260, 24);
            this.txtValor.TabIndex = 23;
            this.txtValor.Visible = false;
            // 
            // CdRegistro
            // 
            this.CdRegistro.DataPropertyName = "CdRegistro";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.CdRegistro.DefaultCellStyle = dataGridViewCellStyle3;
            this.CdRegistro.HeaderText = "Código";
            this.CdRegistro.Name = "CdRegistro";
            this.CdRegistro.ReadOnly = true;
            this.CdRegistro.Width = 60;
            // 
            // StTipoOperacao
            // 
            this.StTipoOperacao.DataPropertyName = "StTipoOperacao";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.StTipoOperacao.DefaultCellStyle = dataGridViewCellStyle4;
            this.StTipoOperacao.HeaderText = "Tipo de Operação";
            this.StTipoOperacao.Name = "StTipoOperacao";
            this.StTipoOperacao.ReadOnly = true;
            this.StTipoOperacao.Width = 148;
            // 
            // DsDescricao
            // 
            this.DsDescricao.DataPropertyName = "DsDescricao";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.DsDescricao.DefaultCellStyle = dataGridViewCellStyle5;
            this.DsDescricao.HeaderText = "Descrição";
            this.DsDescricao.Name = "DsDescricao";
            this.DsDescricao.ReadOnly = true;
            this.DsDescricao.Width = 410;
            // 
            // VlQuantidade
            // 
            this.VlQuantidade.DataPropertyName = "VlQuantidade";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.VlQuantidade.DefaultCellStyle = dataGridViewCellStyle6;
            this.VlQuantidade.HeaderText = "Quantidade";
            this.VlQuantidade.Name = "VlQuantidade";
            this.VlQuantidade.ReadOnly = true;
            // 
            // VlValor
            // 
            this.VlValor.DataPropertyName = "VlValor";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.VlValor.DefaultCellStyle = dataGridViewCellStyle7;
            this.VlValor.HeaderText = "Valor Total";
            this.VlValor.Name = "VlValor";
            this.VlValor.ReadOnly = true;
            this.VlValor.Width = 102;
            // 
            // DtOperacao
            // 
            this.DtOperacao.DataPropertyName = "DtOperacao";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.DtOperacao.DefaultCellStyle = dataGridViewCellStyle8;
            this.DtOperacao.HeaderText = "Data Operação";
            this.DtOperacao.Name = "DtOperacao";
            this.DtOperacao.ReadOnly = true;
            this.DtOperacao.Visible = false;
            this.DtOperacao.Width = 130;
            // 
            // DtRegistro
            // 
            this.DtRegistro.DataPropertyName = "DtRegistro";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.DtRegistro.DefaultCellStyle = dataGridViewCellStyle9;
            this.DtRegistro.HeaderText = "Data do Regristro";
            this.DtRegistro.Name = "DtRegistro";
            this.DtRegistro.ReadOnly = true;
            this.DtRegistro.Visible = false;
            this.DtRegistro.Width = 145;
            // 
            // CdProduto
            // 
            this.CdProduto.DataPropertyName = "CdProduto";
            this.CdProduto.HeaderText = "Código do Produto";
            this.CdProduto.Name = "CdProduto";
            this.CdProduto.ReadOnly = true;
            this.CdProduto.Visible = false;
            // 
            // CdCliente
            // 
            this.CdCliente.DataPropertyName = "CdCliente";
            this.CdCliente.HeaderText = "Código do Cliente";
            this.CdCliente.Name = "CdCliente";
            this.CdCliente.ReadOnly = true;
            this.CdCliente.Visible = false;
            // 
            // CaixaEntradaSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 460);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lbDescricao);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.lbCliente);
            this.Controls.Add(this.cbProduto);
            this.Controls.Add(this.lbFiltro);
            this.Controls.Add(this.cbFiltro);
            this.Controls.Add(this.lbSaldo);
            this.Controls.Add(this.lbDescricaoSaldo);
            this.Controls.Add(this.lbQuantidade);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.grpOperacao);
            this.Controls.Add(this.lbProduto);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.grvCaixaEntradaSaida);
            this.Controls.Add(this.lbData);
            this.Name = "CaixaEntradaSaida";
            this.Text = "CaixaEntradaSaida";
            ((System.ComponentModel.ISupportInitialize)(this.grvCaixaEntradaSaida)).EndInit();
            this.grpOperacao.ResumeLayout(false);
            this.grpOperacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.DataGridView grvCaixaEntradaSaida;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.RadioButton rbEntrada;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lbProduto;
        private System.Windows.Forms.RadioButton rbSaida;
        private System.Windows.Forms.GroupBox grpOperacao;
        private System.Windows.Forms.Label lbQuantidade;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lbDescricaoSaldo;
        private System.Windows.Forms.Label lbSaldo;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.Label lbFiltro;
        private System.Windows.Forms.ComboBox cbProduto;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn StTipoOperacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DsDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn VlQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn VlValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtOperacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdCliente;
    }
}