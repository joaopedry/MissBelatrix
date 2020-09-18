using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissBelatrix.Camadas.Info
{
    public class TamanhoInfo
    {
        [BsonId]
        public int CdTamanho { get; set; }
        public string DsTamanho { get; set; }
    }
}
