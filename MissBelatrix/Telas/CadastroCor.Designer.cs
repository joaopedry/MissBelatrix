namespace MissBelatrix.Telas
{
    partial class CadastroCor
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
            this.lbDsCor = new System.Windows.Forms.Label();
            this.txtDsCor = new System.Windows.Forms.TextBox();
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
            // lbDsCor
            // 
            this.lbDsCor.AutoSize = true;
            this.lbDsCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDsCor.Location = new System.Drawing.Point(9, 17);
            this.lbDsCor.Name = "lbDsCor";
            this.lbDsCor.Size = new System.Drawing.Size(37, 18);
            this.lbDsCor.TabIndex = 31;
            this.lbDsCor.Text = "Cor:";
            // 
            // txtDsCor
            // 
            this.txtDsCor.Location = new System.Drawing.Point(12, 38);
            this.txtDsCor.Multiline = true;
            this.txtDsCor.Name = "txtDsCor";
            this.txtDsCor.Size = new System.Drawing.Size(288, 25);
            this.txtDsCor.TabIndex = 30;
            // 
            // CadastroCor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 122);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lbDsCor);
            this.Controls.Add(this.txtDsCor);
            this.Name = "CadastroCor";
            this.Text = "CadastroCor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lbDsCor;
        private System.Windows.Forms.TextBox txtDsCor;
    }
}