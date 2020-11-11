using MissBelatrix.Camadas.DAL;
using MissBelatrix.Camadas.Info;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissBelatrix.Camadas.BLL
{
    public class RegistroBLL
    {
        public List<RegistroInfo> Listar()
        {
            RegistroDAL dal = new RegistroDAL();
            return dal.Listar();
        }

        public RegistroInfo Get(int pCdRegistro)
        {
            RegistroDAL dal = new RegistroDAL();
            return dal.Get(pCdRegistro);
        }

        public List<RegistroInfo> ListarFiltrado(DateTime pDtInicio, DateTime pDtFim = default(DateTime))
            {
            RegistroDAL dal = new RegistroDAL();
            return dal.ListarFiltrado(pDtInicio, ((pDtFim == DateTime.MinValue) ? DateTime.Now : pDtFim));
        }

        public void Inserir(RegistroInfo pInfo)
        {
            RegistroDAL dal = new RegistroDAL();
            dal.Inserir(pInfo);
        }

        public void Delete(int pCdRegistro)
        {
            RegistroDAL dal = new RegistroDAL();
            dal.Delete(pCdRegistro);
        }
    }
}
