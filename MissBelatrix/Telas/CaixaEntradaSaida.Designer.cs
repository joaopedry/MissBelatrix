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
            ((System.ComponentModel.ISupportInitialize)(this.grvCaixaEntradaSaida)).BeginInit();
            this.grpOperacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(25, 61);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(30, 13);
            this.lbData.TabIndex = 0;
            this.lbData.Text = "Data";
            // 
            // grvCaixaEntradaSaida
            // 
            this.grvCaixaEntradaSaida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCaixaEntradaSaida.Location = new System.Drawing.Point(28, 159);
            this.grvCaixaEntradaSaida.Name = "grvCaixaEntradaSaida";
            this.grvCaixaEntradaSaida.Size = new System.Drawing.Size(743, 246);
            this.grvCaixaEntradaSaida.TabIndex = 2;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(696, 118);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
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
            this.rbEntrada.Size = new System.Drawing.Size(62, 17);
            this.rbEntrada.TabIndex = 4;
            this.rbEntrada.TabStop = true;
            this.rbEntrada.Text = "Entrada";
            this.rbEntrada.UseVisualStyleBackColor = true;
            this.rbEntrada.CheckedChanged += new System.EventHandler(this.rbEntrada_CheckedChanged);
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(28, 77);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(101, 20);
            this.dtpData.TabIndex = 6;
            // 
            // lbProduto
            // 
            this.lbProduto.AutoSize = true;
            this.lbProduto.Location = new System.Drawing.Point(272, 61);
            this.lbProduto.Name = "lbProduto";
            this.lbProduto.Size = new System.Drawing.Size(44, 13);
            this.lbProduto.TabIndex = 7;
            this.lbProduto.Text = "Produto";
            // 
            // rbSaida
            // 
            this.rbSaida.AutoSize = true;
            this.rbSaida.Location = new System.Drawing.Point(107, 19);
            this.rbSaida.Name = "rbSaida";
            this.rbSaida.Size = new System.Drawing.Size(54, 17);
            this.rbSaida.TabIndex = 8;
            this.rbSaida.Text = "Saída";
            this.rbSaida.UseVisualStyleBackColor = true;
            this.rbSaida.CheckedChanged += new System.EventHandler(this.rbSaida_CheckedChanged);
            // 
            // grpOperacao
            // 
            this.grpOperacao.Controls.Add(this.rbEntrada);
            this.grpOperacao.Controls.Add(this.rbSaida);
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
            this.lbQuantidade.Location = new System.Drawing.Point(414, 61);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(65, 13);
            this.lbQuantidade.TabIndex = 11;
            this.lbQuantidade.Text = "Quantidade:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(417, 77);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 10;
            // 
            // lbDescricaoSaldo
            // 
            this.lbDescricaoSaldo.AutoSize = true;
            this.lbDescricaoSaldo.Location = new System.Drawing.Point(633, 419);
            this.lbDescricaoSaldo.Name = "lbDescricaoSaldo";
            this.lbDescricaoSaldo.Size = new System.Drawing.Size(34, 13);
            this.lbDescricaoSaldo.TabIndex = 12;
            this.lbDescricaoSaldo.Text = "Saldo";
            // 
            // lbSaldo
            // 
            this.lbSaldo.AutoSize = true;
            this.lbSaldo.Location = new System.Drawing.Point(704, 419);
            this.lbSaldo.Name = "lbSaldo";
            this.lbSaldo.Size = new System.Drawing.Size(10, 13);
            this.lbSaldo.TabIndex = 13;
            this.lbSaldo.Text = "-";
            // 
            // cbFiltro
            // 
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Location = new System.Drawing.Point(62, 417);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(121, 21);
            this.cbFiltro.TabIndex = 14;
            this.cbFiltro.SelectionChangeCommitted += new System.EventHandler(this.cbFiltro_SelectionChangeCommitted);
            // 
            // lbFiltro
            // 
            this.lbFiltro.AutoSize = true;
            this.lbFiltro.Location = new System.Drawing.Point(21, 419);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(32, 13);
            this.lbFiltro.TabIndex = 15;
            this.lbFiltro.Text = "Filtro:";
            // 
            // cbProduto
            // 
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(275, 77);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(121, 21);
            this.cbProduto.TabIndex = 16;
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(145, 76);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(121, 21);
            this.cbCliente.TabIndex = 18;
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Location = new System.Drawing.Point(142, 60);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(42, 13);
            this.lbCliente.TabIndex = 17;
            this.lbCliente.Text = "Cliente:";
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Location = new System.Drawing.Point(142, 105);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(58, 13);
            this.lbDescricao.TabIndex = 22;
            this.lbDescricao.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(145, 121);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(100, 20);
            this.txtDescricao.TabIndex = 21;
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(257, 105);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(34, 13);
            this.lbValor.TabIndex = 24;
            this.lbValor.Text = "Valor:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(260, 121);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 23;
            // 
            // CaixaEntradaSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}