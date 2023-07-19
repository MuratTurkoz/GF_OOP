using GFA.Crawler.Domain.Entities;

namespace GFA.Crawler.Application.Models
{
    public class ProductCrawlerResponseDto
    {
        //public byte[] ExcelFile { get; set; }
        //public string ExcelFilePath { get; set; }

        public int TotalCount { get; set; }
        public int OnSaleCount => Products.Count(p=>p.IsOnSale);
        public int SaleCount=>Products.Count(p => p.IsOnSale==false);

        public List<Product> Products { get; set; }
        public ProductCrawlerResponseDto()
        {
            Products = new List<Product>();
        }
        public ProductCrawlerResponseDto(List<Product> products)
        {
            Products = products;
        }
    }
}
