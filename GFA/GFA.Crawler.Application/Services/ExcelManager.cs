using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using GFA.Crawler.Application.Interfaces;
using GFA.Crawler.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFA.Crawler.Application.Services
{
    public class ExcelManager : IExcelServices
    {
        public byte[] CreateProductsFile(List<Product> product)
        {
            Product p = new Product();

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Products");



                for (int i = 0; i < product.Count; i++)
                {
                    worksheet.Cell($"A{i + 1}").Value = product[i].Id.ToString();
                    worksheet.Cell($"A{i + 1}").Value = product[i].Name.ToString();
                    worksheet.Cell($"A{i + 1}").Value = product[i].IsOnSale.ToString();
                    worksheet.Cell($"A{i + 1}").Value = product[i].Price.ToString("C");
                    worksheet.Cell($"A{i + 1}").Value = product[i].SalePrice.ToString();
                    worksheet.Cell($"A{i + 1}").Value = product[i].SalePrice.HasValue ? product[i].SalePrice.Value.ToString() : "Not on Sale";
                    workbook.SaveAs("C:\\Users\\Murat\\Desktop");
                }
                var firstCell = worksheet.FirstCellUsed();
                var lastCell = worksheet.LastCellUsed();

                var range = worksheet.Range(firstCell.Address, lastCell.Address);


                var table = range.CreateTable();
                //return workbook.Worksheets
                using (var memoryStream = new MemoryStream())
                {
                    workbook.SaveAs(memoryStream);
                    return memoryStream.ToArray();
                }
            }
        }

        public void SaveFile(byte[] excelFile, string fileName, string filePath)
        {
            throw new NotImplementedException();
        }

        public void CreateStyledCell(byte[] excelFile, string fileName, string filePath)
        {

        }
    }
}
