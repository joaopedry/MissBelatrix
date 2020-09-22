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
                    List<CorInfo> info = db.GetCollection<CorInfo>().FindAll().ToList();
                    return info;
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public void Inserir(CorInfo info)
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(dataBase.DataBaseConnection()))
                {
                    db.GetCollection<CorInfo>().Insert(info);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public void Update(CorInfo info)
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(dataBase.DataBaseConnection()))
                {
                    db.GetCollection<CorInfo>().Update(info);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public int GetCdCor(string DsCor)
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(dataBase.DataBaseConnection()))
                {
                    return Listar().Find(x => x.DsCor == DsCor).CdCor;
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
    }
}
