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
    public class CorDAL
    {
        DataBaseConnect dataBase = new DataBaseConnect();
        public List<CorInfo> Listar()
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(dataBase.DataBaseConnection()))
                {
                    return db.GetCollection<CorInfo>().FindAll().ToList();
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public void Inserir(CorInfo pInfo)
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(dataBase.DataBaseConnection()))
                {
                    db.GetCollection<CorInfo>().Insert(pInfo);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public CorInfo Get(int pCdCor)
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(dataBase.DataBaseConnection()))
                {
                    return db.GetCollection<CorInfo>().FindById(pCdCor);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public void Update(CorInfo pInfo)
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(dataBase.DataBaseConnection()))
                {
                    db.GetCollection<CorInfo>().Update(pInfo);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public void Delete(int pCdCor)
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(dataBase.DataBaseConnection()))
                {
                    db.GetCollection<CorInfo>().Delete(pCdCor);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
    }
}
