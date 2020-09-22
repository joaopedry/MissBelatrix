using MissBelatrix.Camadas.DAL;
using MissBelatrix.Camadas.Info;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissBelatrix.Camadas.BLL
{
    public class VendaBLL
    {
        public List<VendaInfo> Listar()
        {
            VendaDAL dal = new VendaDAL();
            return dal.Listar();
        }

        public void Inserir(VendaInfo info)
        {
            VendaDAL dal = new VendaDAL();
            dal.Inserir(info);
        }
    }
}
