using MissBelatrix.Camadas.DAL;
using MissBelatrix.Camadas.Info;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissBelatrix.Camadas.BLL
{
    public class ClienteBLL
    {
        public List<ClienteInfo> Listar()
        {
            ClienteDAL dal = new ClienteDAL();
            return dal.Listar();
        }

        public void Inserir(ClienteInfo info)
        {
            ClienteDAL dal = new ClienteDAL();
            dal.Inserir(info);
        }
    }
}
