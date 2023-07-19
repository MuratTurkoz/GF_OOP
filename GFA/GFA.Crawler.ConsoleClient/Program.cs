using GFA.Crawler.Application.Interfaces;
using GFA.Crawler.Application.Services;
using GFA.Crawler.ConsoleClient.Services;
using GFA.Crawler.Domain.Entities;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;


Console.WriteLine("Uygulama başladı.");
Console.BackgroundColor = ConsoleColor.Green;
Console.ForegroundColor = ConsoleColor.Black;
IProductCrawlerService crawlerService = new ProductCrawlerConsoleManager();
var response=crawlerService.Crawl(5);

Console.WriteLine();
Console.WriteLine($"İndirimdeki ürünlerin sayısı:{response.Products.Count}");
Console.WriteLine($"İndirimdeki ürünlerin sayısı:{response.OnSaleCount}");
Console.WriteLine($"İndirimdeki ürünlerin sayısı:{response.SaleCount}");
Console.BackgroundColor= ConsoleColor.Green;
Console.ForegroundColor = ConsoleColor.Black;
IExcelServices excel=new ExcelManager();
excel.CreateProductsFile(response.Products);

Console.ReadLine();