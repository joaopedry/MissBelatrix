namespace MissBelatrix.Telas
{
    partial class Relatorios
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
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.lbDtInicio = new System.Windows.Forms.Label();
            this.lbDtFim = new System.Windows.Forms.Label();
            this.btGerarRelatorio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(28, 47);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(105, 20);
            this.dtpInicio.TabIndex = 0;
            // 
            // dtpFim
            // 
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(183, 47);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(105, 20);
            this.dtpFim.TabIndex = 1;
            // 
            // lbDtInicio
            // 
            this.lbDtInicio.AutoSize = true;
            this.lbDtInicio.Location = new System.Drawing.Point(28, 28);
            this.lbDtInicio.Name = "lbDtInicio";
            this.lbDtInicio.Size = new System.Drawing.Size(60, 13);
            this.lbDtInicio.TabIndex = 2;
            this.lbDtInicio.Text = "Data Início";
            // 
            // lbDtFim
            // 
            this.lbDtFim.AutoSize = true;
            this.lbDtFim.Location = new System.Drawing.Point(180, 28);
            this.lbDtFim.Name = "lbDtFim";
            this.lbDtFim.Size = new System.Drawing.Size(49, 13);
            this.lbDtFim.TabIndex = 3;
            this.lbDtFim.Text = "Data Fim";
            // 
            // btGerarRelatorio
            // 
            this.btGerarRelatorio.Location = new System.Drawing.Point(195, 88);
            this.btGerarRelatorio.Name = "btGerarRelatorio";
            this.btGerarRelatorio.Size = new System.Drawing.Size(93, 23);
            this.btGerarRelatorio.TabIndex = 4;
            this.btGerarRelatorio.Text = "Gerar Relatório";
            this.btGerarRelatorio.UseVisualStyleBackColor = true;
            this.btGerarRelatorio.Click += new System.EventHandler(this.btGerarRelatorio_Click);
            // 
            // Relatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 128);
            this.Controls.Add(this.btGerarRelatorio);
            this.Controls.Add(this.lbDtFim);
            this.Controls.Add(this.lbDtInicio);
            this.Controls.Add(this.dtpFim);
            this.Controls.Add(this.dtpInicio);
            this.Name = "Relatorios";
            this.Text = "Relatorios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.Label lbDtInicio;
        private System.Windows.Forms.Label lbDtFim;
        private System.Windows.Forms.Button btGerarRelatorio;
    }
}