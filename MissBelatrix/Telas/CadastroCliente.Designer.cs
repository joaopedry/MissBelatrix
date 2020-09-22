namespace MissBelatrix.Telas
{
    partial class CadastroCliente
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
            this.txtDsCliente = new System.Windows.Forms.TextBox();
            this.lbDsCliente = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.rbIdGeneroMasculino = new System.Windows.Forms.RadioButton();
            this.cbCdTipoAcesso = new System.Windows.Forms.ComboBox();
            this.lbDsEmail = new System.Windows.Forms.Label();
            this.txtDsEmail = new System.Windows.Forms.TextBox();
            this.lbDsFone = new System.Windows.Forms.Label();
            this.txtDsFone = new System.Windows.Forms.TextBox();
            this.lbCdTipoAcesso = new System.Windows.Forms.Label();
            this.rbIdGeneroFeninimo = new System.Windows.Forms.RadioButton();
            this.grbGenero = new System.Windows.Forms.GroupBox();
            this.grbGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDsCliente
            // 
            this.txtDsCliente.Location = new System.Drawing.Point(30, 45);
            this.txtDsCliente.Multiline = true;
            this.txtDsCliente.Name = "txtDsCliente";
            this.txtDsCliente.Size = new System.Drawing.Size(420, 25);
            this.txtDsCliente.TabIndex = 0;
            // 
            // lbDsCliente
            // 
            this.lbDsCliente.AutoSize = true;
            this.lbDsCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDsCliente.Location = new System.Drawing.Point(27, 24);
            this.lbDsCliente.Name = "lbDsCliente";
            this.lbDsCliente.Size = new System.Drawing.Size(53, 18);
            this.lbDsCliente.TabIndex = 1;
            this.lbDsCliente.Text = "Nome:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(361, 303);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(87, 30);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // rbIdGeneroMasculino
            // 
            this.rbIdGeneroMasculino.AutoSize = true;
            this.rbIdGeneroMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.rbIdGeneroMasculino.Location = new System.Drawing.Point(6, 47);
            this.rbIdGeneroMasculino.Name = "rbIdGeneroMasculino";
            this.rbIdGeneroMasculino.Size = new System.Drawing.Size(94, 22);
            this.rbIdGeneroMasculino.TabIndex = 3;
            this.rbIdGeneroMasculino.Text = "Masculino";
            this.rbIdGeneroMasculino.UseVisualStyleBackColor = true;
            // 
            // cbCdTipoAcesso
            // 
            this.cbCdTipoAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.cbCdTipoAcesso.FormattingEnabled = true;
            this.cbCdTipoAcesso.Location = new System.Drawing.Point(258, 163);
            this.cbCdTipoAcesso.Name = "cbCdTipoAcesso";
            this.cbCdTipoAcesso.Size = new System.Drawing.Size(192, 25);
            this.cbCdTipoAcesso.TabIndex = 4;
            // 
            // lbDsEmail
            // 
            this.lbDsEmail.AutoSize = true;
            this.lbDsEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbDsEmail.Location = new System.Drawing.Point(27, 82);
            this.lbDsEmail.Name = "lbDsEmail";
            this.lbDsEmail.Size = new System.Drawing.Size(54, 18);
            this.lbDsEmail.TabIndex = 6;
            this.lbDsEmail.Text = "E-mail:";
            // 
            // txtDsEmail
            // 
            this.txtDsEmail.Location = new System.Drawing.Point(30, 103);
            this.txtDsEmail.Multiline = true;
            this.txtDsEmail.Name = "txtDsEmail";
            this.txtDsEmail.Size = new System.Drawing.Size(420, 25);
            this.txtDsEmail.TabIndex = 5;
            // 
            // lbDsFone
            // 
            this.lbDsFone.AutoSize = true;
            this.lbDsFone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbDsFone.Location = new System.Drawing.Point(27, 142);
            this.lbDsFone.Name = "lbDsFone";
            this.lbDsFone.Size = new System.Drawing.Size(69, 18);
            this.lbDsFone.TabIndex = 8;
            this.lbDsFone.Text = "Telefone:";
            // 
            // txtDsFone
            // 
            this.txtDsFone.Location = new System.Drawing.Point(30, 163);
            this.txtDsFone.Multiline = true;
            this.txtDsFone.Name = "txtDsFone";
            this.txtDsFone.Size = new System.Drawing.Size(192, 25);
            this.txtDsFone.TabIndex = 7;
            // 
            // lbCdTipoAcesso
            // 
            this.lbCdTipoAcesso.AutoSize = true;
            this.lbCdTipoAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbCdTipoAcesso.Location = new System.Drawing.Point(255, 142);
            this.lbCdTipoAcesso.Name = "lbCdTipoAcesso";
            this.lbCdTipoAcesso.Size = new System.Drawing.Size(115, 18);
            this.lbCdTipoAcesso.TabIndex = 9;
            this.lbCdTipoAcesso.Text = "Tipo de Acesso:";
            // 
            // rbIdGeneroFeninimo
            // 
            this.rbIdGeneroFeninimo.AutoSize = true;
            this.rbIdGeneroFeninimo.Checked = true;
            this.rbIdGeneroFeninimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.rbIdGeneroFeninimo.Location = new System.Drawing.Point(6, 19);
            this.rbIdGeneroFeninimo.Name = "rbIdGeneroFeninimo";
            this.rbIdGeneroFeninimo.Size = new System.Drawing.Size(87, 22);
            this.rbIdGeneroFeninimo.TabIndex = 10;
            this.rbIdGeneroFeninimo.TabStop = true;
            this.rbIdGeneroFeninimo.Text = "Feminino";
            this.rbIdGeneroFeninimo.UseVisualStyleBackColor = true;
            // 
            // grbGenero
            // 
            this.grbGenero.Controls.Add(this.rbIdGeneroFeninimo);
            this.grbGenero.Controls.Add(this.rbIdGeneroMasculino);
            this.grbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbGenero.Location = new System.Drawing.Point(30, 207);
            this.grbGenero.Name = "grbGenero";
            this.grbGenero.Size = new System.Drawing.Size(178, 80);
            this.grbGenero.TabIndex = 13;
            this.grbGenero.TabStop = false;
            this.grbGenero.Text = "Gênero:";
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 344);
            this.Controls.Add(this.grbGenero);
            this.Controls.Add(this.lbCdTipoAcesso);
            this.Controls.Add(this.lbDsFone);
            this.Controls.Add(this.txtDsFone);
            this.Controls.Add(this.lbDsEmail);
            this.Controls.Add(this.txtDsEmail);
            this.Controls.Add(this.cbCdTipoAcesso);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lbDsCliente);
            this.Controls.Add(this.txtDsCliente);
            this.Name = "CadastroCliente";
            this.Text = "CadastroCliente";
            this.Load += new System.EventHandler(this.CadastroCliente_Load);
            this.grbGenero.ResumeLayout(false);
            this.grbGenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDsCliente;
        private System.Windows.Forms.Label lbDsCliente;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.RadioButton rbIdGeneroMasculino;
        private System.Windows.Forms.ComboBox cbCdTipoAcesso;
        private System.Windows.Forms.Label lbDsEmail;
        private System.Windows.Forms.TextBox txtDsEmail;
        private System.Windows.Forms.Label lbDsFone;
        private System.Windows.Forms.TextBox txtDsFone;
        private System.Windows.Forms.Label lbCdTipoAcesso;
        private System.Windows.Forms.RadioButton rbIdGeneroFeninimo;
        private System.Windows.Forms.GroupBox grbGenero;
    }
}