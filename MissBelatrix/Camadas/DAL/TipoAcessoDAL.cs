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

        public void Inserir(TipoAcessoInfo info)
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(dataBase.DataBaseConnection()))
                {
                    db.GetCollection<TipoAcessoInfo>().Insert(info);
                }
            }
            catch(Exception ex)
            { throw ex; }
        }
    }
}
