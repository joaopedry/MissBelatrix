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

        public int GetCdCor(string DsCor)
        {
            CorDAL dal = new CorDAL();
            return dal.GetCdCor(DsCor);
        }

        public void Inserir(CorInfo info)
        {
            CorDAL dal = new CorDAL();
            dal.Inserir(info);
        }

        public void Update(CorInfo info)
        {
            CorDAL dal = new CorDAL();
            dal.Update(info);
        }
    }
}
