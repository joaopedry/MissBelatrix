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
    public partial class CaixaEntradaSaida : Form
    {
        public CaixaEntradaSaida()
        {
            InitializeComponent();
            CarregaProdutos();
            CarregaClientes();
            CarregaFiltroLista();
            CarregaListaEntradaSaida();
            HabilitaCamposEntrada();
        }

        private void CarregaProdutos()
        {
            ProdutoBLL bll = new ProdutoBLL();
            cbProduto.DataSource = bll.Listar();
            cbProduto.DisplayMember = "DsProduto";
            cbProduto.ValueMember = "CdProduto";
        }

        private void CarregaClientes()
        {
            ClienteBLL bll = new ClienteBLL();
            cbCliente.DataSource = bll.Listar();
            cbCliente.DisplayMember = "DsCliente";
            cbCliente.ValueMember = "CdCliente";
        }

        private void HabilitaCamposEntrada()
        {
            txtDescricao.Enabled = false;
            txtDescricao.Visible = false;
            txtValor.Enabled = false;
            txtValor.Visible = false;
            lbDescricao.Enabled = false;
            lbDescricao.Visible = false;
            lbValor.Enabled = false;
            lbValor.Visible = false;

            cbCliente.Enabled = true;
            cbCliente.Visible = true;
            cbProduto.Enabled = true;
            cbProduto.Visible = true;
            lbCliente.Visible = true;
            lbProduto.Visible = true;
        }

        private void HabilitaCamposSaida()
        { 
            txtDescricao.Enabled = true;
            txtDescricao.Visible = true;
            txtValor.Enabled = true;
            txtValor.Visible = true;
            lbDescricao.Enabled = true;
            lbDescricao.Visible = true;
            lbValor.Enabled = true;
            lbValor.Visible = true;

            cbCliente.Enabled = false;
            cbCliente.Visible = false;
            cbProduto.Enabled = false;
            cbProduto.Visible = false;
            lbCliente.Visible = false;
            lbProduto.Visible = false;
        }

        private void CarregaFiltroLista()
        {
            cbFiltro.Items.Add(new { Text = "Diário", Value = 0 });
            cbFiltro.Items.Add(new { Text = "Semanal", Value = 1 });
            cbFiltro.Items.Add(new { Text = "Mensal", Value = 2 });
            cbFiltro.Items.Add(new { Text = "Completo", Value = 3 });

            cbFiltro.DisplayMember = "Text";
            cbFiltro.ValueMember = "Value";
            cbFiltro.SelectedIndex = 0;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistraEntradaSaida();
            CarregaListaEntradaSaida();
        }

        public void CarregaListaEntradaSaida()
        {
            RegistroBLL bll = new RegistroBLL();
            grvCaixaEntradaSaida.DataSource = bll.ListarFiltrado(BuscaFiltroData());
            grvCaixaEntradaSaida.Update();
            grvCaixaEntradaSaida.Refresh();

        }

        private DateTime BuscaFiltroData()
        {
            if (cbFiltro.SelectedIndex == 0)
                return DateTime.Now.Date;
            else if (cbFiltro.SelectedIndex == 1)
                return DateTime.Now.AddDays(-7).Date;
            else if (cbFiltro.SelectedIndex == 2)
                return DateTime.Now.AddMonths(-1).Date;
            else
                return DateTime.MinValue.Date;
        }

        private void RegistraEntradaSaida()
        {
            RegistroInfo info = new RegistroInfo();
            RegistroBLL bll = new RegistroBLL();

            info.StTipoOperacao = (rbEntrada.Checked == true) ? 0 : 1;
            info.CdCliente = ((ClienteInfo)cbCliente.SelectedItem).CdCliente;
            info.CdProduto = ((ProdutoInfo)cbProduto.SelectedItem).CdProduto;
            info.DsDescricao = (txtDescricao.Text != string.Empty) ? txtDescricao.Text : ((ProdutoInfo)cbProduto.SelectedItem).DsProduto;
            info.DtRegistro = DateTime.Now;
            info.DtOperacao = dtpData.Value;
            info.VlValor = CalculaValorTotal(((ProdutoInfo)cbProduto.SelectedItem).CdProduto, txtValor.Text, txtQuantidade.Text);
            info.VlQuantidade = Convert.ToInt32(txtQuantidade.Text);
            bll.Inserir(info);
        }

        private string CalculaValorTotal(int CdProduto, string VlValor, string VlQuantidade)
        {
            if(rbEntrada.Checked == true)
            {
                ProdutoBLL bll = new ProdutoBLL();
                return ((bll.Get(CdProduto).VlPreco) * Convert.ToInt32(VlQuantidade)).ToString();
            }
            else
            {
                return ((float)Convert.ToDouble(VlValor) * Convert.ToInt32(VlQuantidade)).ToString();
            }
        }

        private void rbEntrada_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaCamposEntrada();
        }

        private void rbSaida_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaCamposSaida();
        }

        private void cbFiltro_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CarregaListaEntradaSaida();
        }
    }
}
