using MissBelatrix.Camadas.DAL;
using MissBelatrix.Camadas.Info;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissBelatrix.Camadas.BLL
{
    public class TamanhoBLL
    {
        public List<TamanhoInfo> Listar()
        {
            TamanhoDAL dal = new TamanhoDAL();
            return dal.Listar();
        }

        public void Inserir(TamanhoInfo info)
        {
            TamanhoDAL dal = new TamanhoDAL();
            dal.Inserir(info);
        }
    }
}
