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
    public class ProdutoDAL
    {
        DataBaseConnect dataBase = new DataBaseConnect();
        public List<ProdutoInfo> Listar()
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(dataBase.DataBaseConnection()))
                {
                    List<ProdutoInfo> info = db.GetCollection<ProdutoInfo>().FindAll().ToList();
                    return info;
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public void Inserir(ProdutoInfo pInfo)
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(dataBase.DataBaseConnection()))
                {
                    db.GetCollection<ProdutoInfo>().Insert(pInfo);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ProdutoInfo Get(int pCdProduto)
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(dataBase.DataBaseConnection()))
                {
                    return db.GetCollection<ProdutoInfo>().FindById(pCdProduto);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public void Update(ProdutoInfo pInfo)
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(dataBase.DataBaseConnection()))
                {
                    db.GetCollection<ProdutoInfo>().Update(pInfo);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public void Delete(int pCdProduto)
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(dataBase.DataBaseConnection()))
                {
                    db.GetCollection<ProdutoInfo>().Delete(pCdProduto);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
    }
}
