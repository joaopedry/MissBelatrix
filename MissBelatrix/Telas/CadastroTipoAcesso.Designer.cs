﻿namespace MissBelatrix.Telas
{
    partial class CadastroTipoAcesso
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
            this.lbDsTipoAcesso = new System.Windows.Forms.Label();
            this.txtDsTipoAcesso = new System.Windows.Forms.TextBox();
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
            // lbDsTipoAcesso
            // 
            this.lbDsTipoAcesso.AutoSize = true;
            this.lbDsTipoAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDsTipoAcesso.Location = new System.Drawing.Point(9, 17);
            this.lbDsTipoAcesso.Name = "lbDsTipoAcesso";
            this.lbDsTipoAcesso.Size = new System.Drawing.Size(115, 18);
            this.lbDsTipoAcesso.TabIndex = 31;
            this.lbDsTipoAcesso.Text = "Tipo de Acesso:";
            // 
            // txtDsTipoAcesso
            // 
            this.txtDsTipoAcesso.Location = new System.Drawing.Point(12, 38);
            this.txtDsTipoAcesso.Multiline = true;
            this.txtDsTipoAcesso.Name = "txtDsTipoAcesso";
            this.txtDsTipoAcesso.Size = new System.Drawing.Size(288, 25);
            this.txtDsTipoAcesso.TabIndex = 30;
            // 
            // CadastroTipoAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 122);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lbDsTipoAcesso);
            this.Controls.Add(this.txtDsTipoAcesso);
            this.Name = "CadastroTipoAcesso";
            this.Text = "CadastroTipoAcesso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lbDsTipoAcesso;
        private System.Windows.Forms.TextBox txtDsTipoAcesso;
    }
}