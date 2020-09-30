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
    public class TipoProdutoDAL
    {
        DataBaseConnect dataBase = new DataBaseConnect();
        public List<TipoProdutoInfo> Listar()
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(dataBase.DataBaseConnection()))
                {
                    List<TipoProdutoInfo> info = db.GetCollection<TipoProdutoInfo>().FindAll().ToList();
                    return info;
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public void Inserir(TipoProdutoInfo pInfo)
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(dataBase.DataBaseConnection()))
                {
                    db.GetCollection<TipoProdutoInfo>().Insert(pInfo);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public TipoProdutoInfo Get(int pCdTipoProduto)
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(dataBase.DataBaseConnection()))
                {
                    return db.GetCollection<TipoProdutoInfo>().FindById(pCdTipoProduto);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public void Update(TipoProdutoInfo pInfo)
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(dataBase.DataBaseConnection()))
                {
                    db.GetCollection<TipoProdutoInfo>().Update(pInfo);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public void Delete(int pCdTipoProduto)
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(dataBase.DataBaseConnection()))
                {
                    db.GetCollection<TipoProdutoInfo>().Delete(pCdTipoProduto);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
    }
}
