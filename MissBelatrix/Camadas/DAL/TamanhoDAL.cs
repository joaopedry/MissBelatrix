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
    public class TamanhoDAL
    {
        DataBaseConnect dataBase = new DataBaseConnect();
        public List<TamanhoInfo> Listar()
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(dataBase.DataBaseConnection()))
                {
                    List<TamanhoInfo> info = db.GetCollection<TamanhoInfo>().FindAll().ToList();
                    return info;
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public void Inserir(TamanhoInfo pInfo)
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(dataBase.DataBaseConnection()))
                {
                    db.GetCollection<TamanhoInfo>().Insert(pInfo);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public TamanhoInfo Get(int pCdTamanho)
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(dataBase.DataBaseConnection()))
                {
                    return db.GetCollection<TamanhoInfo>().FindById(pCdTamanho);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public void Update(TamanhoInfo pInfo)
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(dataBase.DataBaseConnection()))
                {
                    db.GetCollection<TamanhoInfo>().Update(pInfo);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public void Delete(int pCdTamanho)
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(dataBase.DataBaseConnection()))
                {
                    db.GetCollection<TamanhoInfo>().Delete(pCdTamanho);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
    }
}
