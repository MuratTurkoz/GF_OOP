using GFA.Crawler.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFA.Crawler.Domain.Business_layer
{
    public class ProductManager
    {
        static List<Product> products=new List<Product>();
        public Product GetProduct(int id)
        {
            return products[id];
        }
        public IQueryable GetsProdcuts()
        {
            return null;
        }
        public void GetOnSaleProduct(Product product)
        {

        }
        public void AddProduct(string name, string imagePath, string unitPrice, string? salePrice, string isOnSale)
        {
            decimal price = Convert.ToDecimal(unitPrice.Replace("$", string.Empty).Replace(",", string.Empty));
            decimal _salePrice = Convert.ToDecimal(unitPrice.Replace("$", string.Empty).Replace(",", string.Empty));
            bool isSale = false;

            if (salePrice != null)
            {
                isSale = true;
            }


            Product product = new Product()
            {
                Name = name,
                ImagePath = imagePath,
                UnitPrice = price,
                SalePrice = _salePrice,
                IsOnSale = isSale
            };
            products.Add(product);

        }
    }
}
