﻿namespace MissBelatrix.Telas
{
    partial class CadastroTipoProduto
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lbDsTipoProduto = new System.Windows.Forms.Label();
            this.txtDsTipoProduto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(213, 80);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(87, 30);
            this.btnCadastrar.TabIndex = 32;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lbDsTipoProduto
            // 
            this.lbDsTipoProduto.AutoSize = true;
            this.lbDsTipoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDsTipoProduto.Location = new System.Drawing.Point(9, 17);
            this.lbDsTipoProduto.Name = "lbDsTipoProduto";
            this.lbDsTipoProduto.Size = new System.Drawing.Size(98, 18);
            this.lbDsTipoProduto.TabIndex = 31;
            this.lbDsTipoProduto.Text = "Tipo Produto:";
            // 
            // txtDsTipoProduto
            // 
            this.txtDsTipoProduto.Location = new System.Drawing.Point(12, 38);
            this.txtDsTipoProduto.Multiline = true;
            this.txtDsTipoProduto.Name = "txtDsTipoProduto";
            this.txtDsTipoProduto.Size = new System.Drawing.Size(288, 25);
            this.txtDsTipoProduto.TabIndex = 30;
            // 
            // CadastroTipoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 122);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lbDsTipoProduto);
            this.Controls.Add(this.txtDsTipoProduto);
            this.Name = "CadastroTipoProduto";
            this.Text = "CadastroTipoProduto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lbDsTipoProduto;
        private System.Windows.Forms.TextBox txtDsTipoProduto;
    }
}