using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissBelatrix.Camadas.Info
{
    public class TipoAcessoInfo
    {
        [BsonId]
        public int CdTipoAcesso { get; set; }
        public string DsTipoAcesso { get; set; }
    }
}
