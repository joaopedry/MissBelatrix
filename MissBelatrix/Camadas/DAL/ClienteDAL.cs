using LiteDB;
using MissBelatrix.Camadas.Info;
using MissBelatrix.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissBelatrix.Camadas.DAL
{
    public class ClienteDAL
    {
        DataBaseConnect dataBase = new DataBaseConnect();
        public List<ClienteInfo> Listar()
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(dataBase.DataBaseConnection()))
                {
                    List<ClienteInfo> info = db.GetCollection<ClienteInfo>().FindAll().ToList();
                    return info;
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public void Inserir(ClienteInfo pInfo)
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(dataBase.DataBaseConnection()))
                {
                    db.GetCollection<ClienteInfo>().Insert(pInfo);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ClienteInfo Get(int pCdCliente)
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(dataBase.DataBaseConnection()))
                {
                    return db.GetCollection<ClienteInfo>().FindById(pCdCliente);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public void Update(ClienteInfo pInfo)
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(dataBase.DataBaseConnection()))
                {
                    db.GetCollection<ClienteInfo>().Update(pInfo);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public void Delete(int pCdCliente)
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(dataBase.DataBaseConnection()))
                {
                    db.GetCollection<ClienteInfo>().Delete(pCdCliente);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
    }
}
