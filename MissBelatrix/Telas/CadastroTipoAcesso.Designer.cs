namespace MissBelatrix.Telas
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
            this.txtDsTipoAcesso = new System.Windows.Forms.TextBox();
            this.lbTipoAcesso = new System.Windows.Forms.Label();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDsTipoAcesso
            // 
            this.txtDsTipoAcesso.Location = new System.Drawing.Point(12, 49);
            this.txtDsTipoAcesso.Name = "txtDsTipoAcesso";
            this.txtDsTipoAcesso.Size = new System.Drawing.Size(235, 20);
            this.txtDsTipoAcesso.TabIndex = 0;
            // 
            // lbTipoAcesso
            // 
            this.lbTipoAcesso.AutoSize = true;
            this.lbTipoAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipoAcesso.Location = new System.Drawing.Point(12, 28);
            this.lbTipoAcesso.Name = "lbTipoAcesso";
            this.lbTipoAcesso.Size = new System.Drawing.Size(115, 18);
            this.lbTipoAcesso.TabIndex = 1;
            this.lbTipoAcesso.Text = "Tipo de Acesso:";
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(172, 86);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btCadastrar.TabIndex = 2;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // CadastroTipoAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 128);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.lbTipoAcesso);
            this.Controls.Add(this.txtDsTipoAcesso);
            this.Name = "CadastroTipoAcesso";
            this.Text = "CadastroTipoAcesso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDsTipoAcesso;
        private System.Windows.Forms.Label lbTipoAcesso;
        private System.Windows.Forms.Button btCadastrar;
    }
}