using ClosedXML.Excel;
using MissBelatrix.Camadas.BLL;
using MissBelatrix.Camadas.Info;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissBelatrix.Classes
{
    public class Relatorio
    {
        public void GerarRelatorio(DateTime pDtInicio, DateTime pDtFim, string pPath)
        {
            RegistroBLL bll = new RegistroBLL();
            List<RegistroInfo> info = new List<RegistroInfo>();
            info = bll.ListarFiltrado(pDtInicio, pDtFim);
            string extension = ".xlsx";

            XLWorkbook workbook = new XLWorkbook();
            workbook.AddWorksheet("Relatorio" + DateTime.Now.ToString("dd-MM-yyyy"));
            IXLWorksheet ws = workbook.Worksheet("Relatorio" + DateTime.Now.ToString("dd-MM-yyyy"));

            //Cabeçalho
            ws.Cell("A" + 1).Value = "CdCliente";
            ws.Cell("B" + 1).Value = "CdProduto";
            ws.Cell("C" + 1).Value = "CdRegistro";
            ws.Cell("D" + 1).Value = "DsDescricao";
            ws.Cell("E" + 1).Value = "DtOperacao";
            ws.Cell("F" + 1).Value = "DtRegistro";
            ws.Cell("G" + 1).Value = "StTipoOperacao";
            ws.Cell("H" + 1).Value = "VlQuantidade";
            ws.Cell("I" + 1).Value = "VlValor";

            int row = 2; //Começar na Segunda linha devido ao Cabeçalho
            foreach (var c in info)
            {
                //Conteúdo
                ws.Cell("A" + row.ToString()).Value = c.CdCliente;
                ws.Cell("B" + row.ToString()).Value = c.CdProduto;
                ws.Cell("C" + row.ToString()).Value = c.CdRegistro;
                ws.Cell("D" + row.ToString()).Value = c.DsDescricao;
                ws.Cell("E" + row.ToString()).Value = c.DtOperacao;
                ws.Cell("F" + row.ToString()).Value = c.DtRegistro;
                ws.Cell("G" + row.ToString()).Value = c.StTipoOperacao;
                ws.Cell("H" + row.ToString()).Value = c.VlQuantidade;
                ws.Cell("I" + row.ToString()).Value = c.VlValor;
                row++;
            }
            pPath = pPath + "\\Report_" + Guid.NewGuid() + extension;
            if (!File.Exists(pPath))
            {
                workbook.SaveAs(pPath);
            }
            else
            {
                File.Delete(pPath);
                workbook.SaveAs(pPath);
            }
        }
    }
}