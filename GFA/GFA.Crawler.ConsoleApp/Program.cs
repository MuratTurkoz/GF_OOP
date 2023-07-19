// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.DevTools.V112.Accessibility;
using GFA.Crawler.Domain;
using GFA.Crawler.Domain.Entities;
using GFA.Crawler.Domain.Business_layer;

Console.WriteLine("Hello, World!");
IWebDriver driver = new ChromeDriver();
driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(1000);

// Text Area Class = gLFyf
// Search Btn Class = gNO89b

driver.Navigate().GoToUrl("https://4teker.net/");

Thread.Sleep(500);
ProductManager productManager = new ProductManager();
//var searchBox = driver.FindElement(By.ClassName("product-name")).GetAttribute("h5");
var productDivs = driver.FindElements(By.CssSelector(".card.h-100"));

foreach (var element in productDivs)
{
        var onSale = element.FindElement(!By.CssSelector(".onsale"));
    if (onSale is not null)
    {
        onSale ="true";
    }
    else
    {
        var onSale = null;
    }

    var ProductName = element.FindElement(By.CssSelector(".product-name"));
    var imagePath = element.FindElement(By.CssSelector(".card-img-top"));
    var price = element.FindElement(By.CssSelector(".price"));
    var onSalePrice = element.FindElement(By.CssSelector(".sale-price"));
    productManager.AddProduct(ProductName.Text, imagePath.Text, price.Text, onSalePrice.Text, onSale.Text);

    //Console.WriteLine("**********");
}
Console.WriteLine(productManager.GetProduct(1));
//var submitButton = driver.FindElement(By.ClassName("gNO89b"));

//searchBox.SendKeys("Alper Tunga");
//submitButton.Click();
//Console.WriteLine(productsDiv);

//var submitButton = driver.FindElement(By.TagName("button"));

Thread.Sleep(1000);

Thread.Sleep(7500);
driver.Quit();
Console.ReadLine();

//ExampleOne();

//[TestMethod]
//void ChromeSession()
//{
//    IWebDriver driver = new ChromeDriver();

//    driver.Navigate().GoToUrl("https://www.selenium.dev/selenium/web/web-form.html");

//    var title = driver.Title;
//    Assert.AreEqual("Web form", title);

//    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);

//    Thread.Sleep(7500);
//    var textBox = driver.FindElement(By.Name("my-text"));
//    var submitButton = driver.FindElement(By.TagName("button"));

//    textBox.SendKeys("Selenium");
//    Thread.Sleep(7500);

//    submitButton.Click();
//    Thread.Sleep(7500);

//    var message = driver.FindElement(By.Id("message"));
//    var value = message.Text;
//    Assert.AreEqual("Received!", value);
//    Thread.Sleep(7500);

//    driver.Quit();
//}

static void ExampleOne()
{
    IWebDriver driver = new ChromeDriver();
    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(1000);

    // Text Area Class = gLFyf
    // Search Btn Class = gNO89b

    driver.Navigate().GoToUrl("https://www.google.com/");

    Thread.Sleep(500);

    var searchBox = driver.FindElement(By.ClassName("gLFyf"));
    var submitButton = driver.FindElement(By.ClassName("gNO89b"));

    searchBox.SendKeys("Alper Tunga");
    submitButton.Click();
    Console.WriteLine(searchBox);

    //var submitButton = driver.FindElement(By.TagName("button"));

    Thread.Sleep(1000);

    Thread.Sleep(7500);
    driver.Quit();
    Console.ReadLine();
}