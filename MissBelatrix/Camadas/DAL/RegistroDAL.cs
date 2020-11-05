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
    public class RegistroDAL
    {
        DataBaseConnect dataBase = new DataBaseConnect();
        public List<RegistroInfo> Listar()
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(dataBase.DataBaseConnection()))
                {
                    List<RegistroInfo> info = db.GetCollection<RegistroInfo>().FindAll().ToList();
                    return info;
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public List<RegistroInfo> ListarFiltrado(DateTime pDtLancamentoFiltro)
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(dataBase.DataBaseConnection()))
                {
                    List<RegistroInfo> info = db.GetCollection<RegistroInfo>().Find(x => x.DtOperacao >= pDtLancamentoFiltro).ToList();

                    return info;
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public void Inserir(RegistroInfo pInfo)
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(dataBase.DataBaseConnection()))
                {
                    db.GetCollection<RegistroInfo>().Insert(pInfo);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
    }
}
