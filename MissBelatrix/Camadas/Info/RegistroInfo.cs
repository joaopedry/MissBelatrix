using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissBelatrix.Camadas.Info
{
    public class RegistroInfo
    {
        [BsonId]
        public int CdRegistro { get; set; }
        public int StTipoOperacao { get; set; }
        public DateTime DtRegistro { get; set; }
        public DateTime DtLancamento { get; set; }
        public int CdProduto { get; set; }
        public int CdCliente { get; set; }
        public int VlQuantidade { get; set; }
        public string DsDescricao { get; set; }
        public string VlValor { get; set; }
    }
}
