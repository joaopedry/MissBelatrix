using MissBelatrix.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissBelatrix.Telas
{
    public partial class Relatorios : Form
    {
        public Relatorios()
        {
            InitializeComponent();
        }

        private void btGerarRelatorio_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                Relatorio relatorio = new Relatorio();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    relatorio.GerarRelatorio(dtpInicio.Value, dtpFim.Value, dialog.SelectedPath);
                }
            }
        }
    }
}
