using GFA.Crawler.Application.Interfaces;
using GFA.Crawler.Application.Models;
using GFA.Crawler.Domain.Entities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace GFA.Crawler.ConsoleClient.Services
{
    public class ProductCrawlerConsoleManager : IProductCrawlerService
    {
        private readonly IWebDriver _driver;
        public ProductCrawlerConsoleManager()
        {
            new DriverManager().SetUpDriver(new FirefoxConfig());
            _driver = new ChromeDriver();
        }

        public string CheckGooglePage()
        {
            _driver.Navigate();
            return string.Empty;
        }

        public ProductCrawlerResponseDto Crawl(int productCount)
        {

            string urlToCrawl = "https://4teker.net";
            _driver.Navigate();


            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(1000);

            _driver.Navigate().GoToUrl(urlToCrawl);

            Thread.Sleep(500);

            // Selecting Product Divs
            // col mb-5

            var productDivs = _driver.FindElements(By.CssSelector(".card.h-100"));

            List<Product> products = new();
            foreach (var productDiv in productDivs)
            {
                var product = new Product();

                // Select OnSaleDiv

                var onSaleDiv = productDiv.FindElements(By.ClassName("onsale"));
                //Console.WriteLine(onSaleDiv.Text);

                if (onSaleDiv is not null && onSaleDiv.Any())
                {
                    product.IsOnSale = true;

                    var salePriceSpan = productDiv.FindElement(By.CssSelector(".sale-price"));

                    // Selecting sale price

                    var salePriceText = salePriceSpan.Text;

                    salePriceText = salePriceText
                        .Replace("$", string.Empty)
                        .Replace(",", ".");

                    product.SalePrice = Convert.ToDecimal(salePriceText);

                }

                // Selecting Product Name

                var productNameH5 = productDiv.FindElement(By.CssSelector(".product-name"));

                product.Name = productNameH5.Text;

                // Selecting Price Span

                var priceSpan = productDiv.FindElement(By.CssSelector(".price"));

                var priceText = priceSpan.Text
                    .Replace("$", string.Empty)
                    .Replace(",", ".");

                product.Price = Convert.ToDecimal(priceText);

                // Selecting Image

                var productImg = productDiv.FindElement(By.TagName("img"));

                product.ImagePath = productImg.GetAttribute("src");
                products.Add(product);

            }

            Thread.Sleep(500);

            //var submitButton = _driver.FindElement(By.ClassName("gNO89b"));

            //submitButton.Click();

            Thread.Sleep(7500);

            _driver.Quit();

            return new ProductCrawlerResponseDto(products);
        }
    }
}
