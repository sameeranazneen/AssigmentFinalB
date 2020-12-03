using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AssignmentFinal
{

    class vehicles
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("C:\\chromedriver");
        }

        [Test]
        public void open_website_Test()
        {
            driver.Url = "http://localhost/webProject/home.html";
            driver.Close();
        }



        [Test]
        public void Welcome_message_appears()
        {
            driver.Navigate().GoToUrl("http://localhost/webProject/home.html");
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //wait.Until(d => d.Title.Contains("Hello World"));
            String welcome = driver.FindElement(By.ClassName("panel-heading")).Text;

            Assert.AreEqual("Welcome to this App", welcome);
        }
        //*[@class = 'btn btn-default'][1]
        [Test]
        public void Verify_New_Functionality()
        {
            driver.Navigate().GoToUrl("http://localhost/webProject/home.html");
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //wait.Until(d => d.Title.Contains("Hello World"));
            driver.FindElement(By.XPath("//*[@class = 'btn btn-default'][1]")).Click();
            String title = driver.Title;
            Assert.AreEqual("Add a new vehicle", title);
            Console.WriteLine("The title of the page is" + title);
            //driver.Close();
        }
        [Test]
        public void Verify_Search_Functionality()
        {
            driver.Navigate().GoToUrl("http://localhost/webProject/home.html");
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //wait.Until(d => d.Title.Contains("Hello World"));
            driver.FindElement(By.XPath("//*[@class = 'btn btn-default'][2]")).Click();
            String titlew = driver.Title;
            Console.WriteLine("The title of the page is  " + titlew);
            Assert.AreEqual("Find your vehicle", titlew);
            //driver.Close();
        }

        // verify the search functionality in the "Find your vehicle page"
        [Test]
        public void Verify_Searchbox_Functionality()
        {
            driver.Navigate().GoToUrl("http://localhost/webProject/home.html");

            //wait.Until(d => d.Title.Contains("Hello World"));
            driver.FindElement(By.XPath("//*[@class = 'btn btn-default'][2]")).Click();
            // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            String tt = driver.FindElement(By.ClassName("content-title")).Text;
            Console.WriteLine(tt);
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//*[@placeholder ='Filter by...']")).SendKeys("dodge");
            //driver.Close();
        }

        // creating a new vehicle information 
        [Test]
        public void Verify_create_functionality()
        {
            driver.Navigate().GoToUrl("http://localhost/webProject/home.html");
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //wait.Until(d => d.Title.Contains("Hello World"));
            driver.FindElement(By.XPath("//*[@class = 'btn btn-default'][1]")).Click();
            driver.FindElement(By.Id("sellerName")).SendKeys("John Marker");
            driver.FindElement(By.Id("address")).SendKeys("Waterloo");
            driver.FindElement(By.Id("apartment")).SendKeys("ridgeway");
            driver.FindElement(By.Id("city")).SendKeys("waterloo");
            driver.FindElement(By.XPath("//*[@value='Manitoba']")).Click();
            driver.FindElement(By.Id("phone")).SendKeys("1234567890");
            driver.FindElement(By.Id("email")).SendKeys("John@test.com");
            driver.FindElement(By.XPath("//*[@value='Audi']")).Click();
            driver.FindElement(By.Id("model")).SendKeys("2015");
            driver.FindElement(By.XPath("//*[@value='2015']")).Click();
            driver.FindElement(By.XPath("//*[@class='btn btn-success']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//*[@class='btn btn-danger']")).Click();

        }

        // clicking on JD Power link will navigate to the JDpower page
        [Test]
        public void Verify_JDpower_link()
        {
            driver.Navigate().GoToUrl("http://localhost/webProject/home.html");
            driver.FindElement(By.XPath("//*[@class = 'btn btn-default'][2]")).Click();
            driver.FindElement(By.XPath("//*[@placeholder ='Filter by...']")).SendKeys("dodge");
            driver.FindElement(By.XPath("//*[text()='JdPowerlink']")).Click();

        }


        //  [TearDown]
        // public void closeBrowser()
        //  {
        //   driver.Close();
    }


    }



