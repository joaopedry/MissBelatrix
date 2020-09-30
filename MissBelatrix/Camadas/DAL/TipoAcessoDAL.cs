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
    public class TipoAcessoDAL
    {
        DataBaseConnect dataBase = new DataBaseConnect();
        public List<TipoAcessoInfo> Listar()
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(dataBase.DataBaseConnection()))
                {
                    List<TipoAcessoInfo> info = db.GetCollection<TipoAcessoInfo>().FindAll().ToList();
                    return info;
                }
            }
            catch(Exception ex)
            { throw ex; }
        }

        public void Inserir(TipoAcessoInfo pInfo)
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(dataBase.DataBaseConnection()))
                {
                    db.GetCollection<TipoAcessoInfo>().Insert(pInfo);
                }
            }
            catch(Exception ex)
            { throw ex; }
        }

        public TipoAcessoInfo Get(int pCdTipoAcesso)
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(dataBase.DataBaseConnection()))
                {
                    return db.GetCollection<TipoAcessoInfo>().FindById(pCdTipoAcesso);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public void Update(TipoAcessoInfo pInfo)
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(dataBase.DataBaseConnection()))
                {
                    db.GetCollection<TipoAcessoInfo>().Update(pInfo);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public void Delete(int pCdTipoAcesso)
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(dataBase.DataBaseConnection()))
                {
                    db.GetCollection<TipoAcessoInfo>().Delete(pCdTipoAcesso);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
    }
}
