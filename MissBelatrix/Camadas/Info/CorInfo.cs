using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissBelatrix.Camadas.Info
{
    public class CorInfo
    {
        [BsonId]
        public int CdCor { get; set; }
        public string DsCor { get; set; }
    }
}
