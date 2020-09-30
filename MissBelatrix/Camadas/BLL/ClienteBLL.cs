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

        public ClienteInfo Get(int pCdCliente)
        {
            ClienteDAL dal = new ClienteDAL();
            return dal.Get(pCdCliente);
        }

        public void Inserir(ClienteInfo pInfo)
        {
            ClienteDAL dal = new ClienteDAL();
            dal.Inserir(pInfo);
        }

        public void Update(ClienteInfo pInfo)
        {
            ClienteDAL dal = new ClienteDAL();
            dal.Update(pInfo);
        }

        public void Delete(int pCdCliente)
        {
            ClienteDAL dal = new ClienteDAL();
            dal.Delete(pCdCliente);
        }
    }
}
