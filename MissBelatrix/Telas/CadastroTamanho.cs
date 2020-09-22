using MissBelatrix.Camadas.BLL;
using MissBelatrix.Camadas.Info;
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
    public partial class CadastroTamanho : Form
    {
        public CadastroTamanho()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastraNovoTamanho();
        }

        private void CadastraNovoTamanho()
        {
            TamanhoBLL bll = new TamanhoBLL();
            TamanhoInfo info = new TamanhoInfo();

            info.DsTamanho = txtDsTamanho.Text;
            bll.Inserir(info);
        }
    }
}
