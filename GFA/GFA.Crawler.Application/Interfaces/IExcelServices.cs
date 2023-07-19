using GFA.Crawler.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFA.Crawler.Application.Interfaces
{
    public interface IExcelServices
    {
        byte[] CreateProductsFile(List<Product> product);
        void SaveFile(byte[] excelFile, string fileName, string filePath);
    }
}
