using ClosedXML.Excel;
using MissBelatrix.Camadas.BLL;
using MissBelatrix.Camadas.Info;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissBelatrix.Classes
{
    public class Relatorio
    {
        public void GerarRelatorio(DateTime pDtInicio, DateTime pDtFim)
        {
            RegistroBLL bll = new RegistroBLL();
            List<RegistroInfo> info = new List<RegistroInfo>();
            info = bll.ListarFiltrado(pDtInicio, pDtFim);

            var workbook = new XLWorkbook();
            workbook.AddWorksheet("sheetName");
            var ws = workbook.Worksheet("sheetName");
            //Recorrer el objecto
            int row = 1;
            foreach (var c in info)
            {
                //Escribrie en Excel en cada celda
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
            //Guardar Excel 
            //Ruta = Nombre_Proyecto\bin\Debug
            workbook.SaveAs(@"C:\\Users\\joao.santos\\Documents\\Report.xlsx");
        }
    }
}