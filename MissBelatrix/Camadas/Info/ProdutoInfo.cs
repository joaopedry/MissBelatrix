using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissBelatrix.Camadas.Info
{
    public class ProdutoInfo
    {
        [BsonId]
        public int CdProduto { get; set; }
        public int CdTipoProduto { get; set; }
        public int CdCor { get; set; }
        public int CdTamanho { get; set; }
        public string DsProduto { get; set; }
        public string VlPreco { get; set; }
    }
}
