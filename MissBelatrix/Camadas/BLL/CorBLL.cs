using MissBelatrix.Camadas.DAL;
using MissBelatrix.Camadas.Info;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissBelatrix.Camadas.BLL
{
    public class CorBLL
    {
        public List<CorInfo> Listar()
        {
            CorDAL dal = new CorDAL();
            return dal.Listar();
        }

        public CorInfo Get(int pCdCor)
        {
            CorDAL dal = new CorDAL();
            return dal.Get(pCdCor);
        }

        public void Inserir(CorInfo pInfo)
        {
            CorDAL dal = new CorDAL();
            dal.Inserir(pInfo);
        }

        public void Update(CorInfo pInfo)
        {
            CorDAL dal = new CorDAL();
            dal.Update(pInfo);
        }

        public void Delete(int pCdCor)
        {
            CorDAL dal = new CorDAL();
            dal.Delete(pCdCor);
        }
    }
}
