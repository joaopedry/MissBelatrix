using MissBelatrix.Camadas.DAL;
using MissBelatrix.Camadas.Info;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissBelatrix.Camadas.BLL
{
    public class TipoAcessoBLL
    {
        public List<TipoAcessoInfo> Listar()
        {
            TipoAcessoDAL dal = new TipoAcessoDAL();
            return dal.Listar();
        }

        public void Inserir(TipoAcessoInfo info)
        {
            TipoAcessoDAL dal = new TipoAcessoDAL();
            dal.Inserir(info);
        }
    }
}
