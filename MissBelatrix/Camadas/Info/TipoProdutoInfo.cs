using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissBelatrix.Camadas.Info
{
    public class TipoProdutoInfo
    {
        [BsonId]
        public int CdTipoProduto { get; set; }
        public string DsTipoProduto { get; set; }
    }
}
