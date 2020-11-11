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
    public partial class DetalharEntradaSaida : Form
    {
        public DetalharEntradaSaida(int pCdRegistro)
        {
            InitializeComponent();
            CarregarRegistro(pCdRegistro);
        }

        private void CarregarRegistro(int pCdRegistro)
        {
            RegistroBLL bllRegistro = new RegistroBLL();
            ClienteBLL bllCliente = new ClienteBLL();
            RegistroInfo info = new RegistroInfo();
            info = bllRegistro.Get(pCdRegistro);
            txtCdRegistro.Text = info.CdRegistro.ToString();
            txtStTipoOperacao.Text = ((info.StTipoOperacao == 0) ? "Entrada" : "Saída");
            txtDtRegistro.Text = info.DtRegistro.ToString();
            txtDtOperacao.Text = info.DtOperacao.ToString();
            txtDsDescricaoProduto.Text = info.DsDescricao.ToString();
            txtDsCliente.Text = bllCliente.Get(info.CdCliente).DsCliente;
            txtVlQuantidade.Text = info.VlQuantidade.ToString();
            txtVlValor.Text = info.VlValor.ToString();
        }
    }
}
