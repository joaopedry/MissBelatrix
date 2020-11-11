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
            lbCdRegistro.Text = info.CdRegistro.ToString();
            lbStTipoOperacao.Text = ((info.StTipoOperacao == 0) ? "Entrada" : "Saída");
            lbDtRegistro.Text = info.DtRegistro.ToString();
            lbDtOperacao.Text = info.DtOperacao.ToString();
            lbCdProduto.Text = info.CdProduto.ToString();
            lbDsDescricaoProduto.Text = info.DsDescricao.ToString();
            lbCdCliente.Text = info.CdCliente.ToString();
            lbDsCliente.Text = bllCliente.Get(info.CdCliente).DsCliente;
            lbVlQuantidade.Text = info.VlQuantidade.ToString();
            lbVlValor.Text = info.VlValor.ToString();
        }
    }
}
