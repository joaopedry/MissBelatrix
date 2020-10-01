namespace MissBelatrix.Telas
{
    partial class CadastroProduto
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
            this.lbCdCor = new System.Windows.Forms.Label();
            this.lbVlPreco = new System.Windows.Forms.Label();
            this.txtVlPreco = new System.Windows.Forms.TextBox();
            this.cbCdCor = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lbDsProduto = new System.Windows.Forms.Label();
            this.txtDsProduto = new System.Windows.Forms.TextBox();
            this.lbCdTamanho = new System.Windows.Forms.Label();
            this.cbCdTamanho = new System.Windows.Forms.ComboBox();
            this.lbCdTipoProduto = new System.Windows.Forms.Label();
            this.cbCdTipoProduto = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCdCor
            // 
            this.lbCdCor.AutoSize = true;
            this.lbCdCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbCdCor.Location = new System.Drawing.Point(15, 125);
            this.lbCdCor.Name = "lbCdCor";
            this.lbCdCor.Size = new System.Drawing.Size(33, 18);
            this.lbCdCor.TabIndex = 22;
            this.lbCdCor.Text = "Cor";
            // 
            // lbVlPreco
            // 
            this.lbVlPreco.AutoSize = true;
            this.lbVlPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbVlPreco.Location = new System.Drawing.Point(228, 128);
            this.lbVlPreco.Name = "lbVlPreco";
            this.lbVlPreco.Size = new System.Drawing.Size(72, 18);
            this.lbVlPreco.TabIndex = 19;
            this.lbVlPreco.Text = "Valor Uni:";
            // 
            // txtVlPreco
            // 
            this.txtVlPreco.Location = new System.Drawing.Point(231, 149);
            this.txtVlPreco.Multiline = true;
            this.txtVlPreco.Name = "txtVlPreco";
            this.txtVlPreco.Size = new System.Drawing.Size(169, 25);
            this.txtVlPreco.TabIndex = 18;
            // 
            // cbCdCor
            // 
            this.cbCdCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.cbCdCor.FormattingEnabled = true;
            this.cbCdCor.Location = new System.Drawing.Point(18, 146);
            this.cbCdCor.Name = "cbCdCor";
            this.cbCdCor.Size = new System.Drawing.Size(169, 25);
            this.cbCdCor.TabIndex = 17;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(313, 217);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(87, 30);
            this.btnCadastrar.TabIndex = 16;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lbDsProduto
            // 
            this.lbDsProduto.AutoSize = true;
            this.lbDsProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDsProduto.Location = new System.Drawing.Point(15, 11);
            this.lbDsProduto.Name = "lbDsProduto";
            this.lbDsProduto.Size = new System.Drawing.Size(65, 18);
            this.lbDsProduto.TabIndex = 15;
            this.lbDsProduto.Text = "Produto:";
            // 
            // txtDsProduto
            // 
            this.txtDsProduto.Location = new System.Drawing.Point(18, 32);
            this.txtDsProduto.Multiline = true;
            this.txtDsProduto.Name = "txtDsProduto";
            this.txtDsProduto.Size = new System.Drawing.Size(382, 25);
            this.txtDsProduto.TabIndex = 14;
            // 
            // lbCdTamanho
            // 
            this.lbCdTamanho.AutoSize = true;
            this.lbCdTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbCdTamanho.Location = new System.Drawing.Point(228, 67);
            this.lbCdTamanho.Name = "lbCdTamanho";
            this.lbCdTamanho.Size = new System.Drawing.Size(75, 18);
            this.lbCdTamanho.TabIndex = 24;
            this.lbCdTamanho.Text = "Tamanho:";
            // 
            // cbCdTamanho
            // 
            this.cbCdTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.cbCdTamanho.FormattingEnabled = true;
            this.cbCdTamanho.Location = new System.Drawing.Point(231, 88);
            this.cbCdTamanho.Name = "cbCdTamanho";
            this.cbCdTamanho.Size = new System.Drawing.Size(169, 25);
            this.cbCdTamanho.TabIndex = 23;
            // 
            // lbCdTipoProduto
            // 
            this.lbCdTipoProduto.AutoSize = true;
            this.lbCdTipoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbCdTipoProduto.Location = new System.Drawing.Point(15, 67);
            this.lbCdTipoProduto.Name = "lbCdTipoProduto";
            this.lbCdTipoProduto.Size = new System.Drawing.Size(41, 18);
            this.lbCdTipoProduto.TabIndex = 26;
            this.lbCdTipoProduto.Text = "Tipo:";
            // 
            // cbCdTipoProduto
            // 
            this.cbCdTipoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.cbCdTipoProduto.FormattingEnabled = true;
            this.cbCdTipoProduto.Location = new System.Drawing.Point(18, 88);
            this.cbCdTipoProduto.Name = "cbCdTipoProduto";
            this.cbCdTipoProduto.Size = new System.Drawing.Size(169, 25);
            this.cbCdTipoProduto.TabIndex = 25;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(220, 217);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 30);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Enabled = false;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(313, 217);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(87, 30);
            this.btnAtualizar.TabIndex = 27;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Visible = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 265);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.lbCdTipoProduto);
            this.Controls.Add(this.cbCdTipoProduto);
            this.Controls.Add(this.lbCdTamanho);
            this.Controls.Add(this.cbCdTamanho);
            this.Controls.Add(this.lbCdCor);
            this.Controls.Add(this.lbVlPreco);
            this.Controls.Add(this.txtVlPreco);
            this.Controls.Add(this.cbCdCor);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lbDsProduto);
            this.Controls.Add(this.txtDsProduto);
            this.Name = "CadastroProduto";
            this.Text = "CadastroProduto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbCdCor;
        private System.Windows.Forms.Label lbVlPreco;
        private System.Windows.Forms.TextBox txtVlPreco;
        private System.Windows.Forms.ComboBox cbCdCor;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lbDsProduto;
        private System.Windows.Forms.TextBox txtDsProduto;
        private System.Windows.Forms.Label lbCdTamanho;
        private System.Windows.Forms.ComboBox cbCdTamanho;
        private System.Windows.Forms.Label lbCdTipoProduto;
        private System.Windows.Forms.ComboBox cbCdTipoProduto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAtualizar;
    }
}