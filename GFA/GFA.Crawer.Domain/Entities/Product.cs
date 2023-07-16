using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFA.Crawler.Domain.Entities
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal? SalePrice { get; set; }
        public bool IsOnSale { get; set; }
        public Product()
        {
            ProductId = Guid.NewGuid();
        }
    }
}
