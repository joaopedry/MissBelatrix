using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissBelatrix.Camadas.Info
{
    public class ClienteInfo
    {
        [BsonId]
        public int CdCliente { get; set; }
        public string DsCliente { get; set; }
        public string DsFone { get; set; }
        public string DsEmail { get; set; }
        public int IdGenero { get; set; }
        public int CdTipoAcesso { get; set; }
    }
}
