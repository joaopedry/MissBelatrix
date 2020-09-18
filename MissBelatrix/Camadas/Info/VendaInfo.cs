using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissBelatrix.Camadas.Info
{
    public class VendaInfo
    {
        [BsonId]
        public int CdVenda { get; set; }
        public int CdCliente { get; set; }
        public int CdProduto { get; set; }
        public int CdFormaPagamento { get; set; }
        public int VlQuantidade { get; set; }
        public string DsDescricao { get; set; }
    }
}
