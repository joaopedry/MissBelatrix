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

        public VendaInfo Get(int pCdVenda)
        {
            VendaDAL dal = new VendaDAL();
            return dal.Get(pCdVenda);
        }

        public void Inserir(VendaInfo pInfo)
        {
            VendaDAL dal = new VendaDAL();
            dal.Inserir(pInfo);
        }

        public void Update(VendaInfo pInfo)
        {
            VendaDAL dal = new VendaDAL();
            dal.Update(pInfo);
        }

        public void Delete(int pCdVenda)
        {
            VendaDAL dal = new VendaDAL();
            dal.Delete(pCdVenda);
        }
    }
}
