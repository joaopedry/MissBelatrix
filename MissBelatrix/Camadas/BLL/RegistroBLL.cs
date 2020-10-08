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

        public List<RegistroInfo> ListarFiltrado(DateTime DtRegistroFiltro)
        {
            RegistroDAL dal = new RegistroDAL();
            return dal.ListarFiltrado(DtRegistroFiltro);
        }

        public void Inserir(RegistroInfo pInfo)
        {
            RegistroDAL dal = new RegistroDAL();
            dal.Inserir(pInfo);
        }
    }
}
