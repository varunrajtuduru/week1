using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver;
            driver = new ChromeDriver("C:\\SeleniumJar");
            string url = "https://www.google.com";
            driver.Url = url;
            string s = "DXC Technologies";
            driver.FindElement(By.Name("q")).SendKeys(s);
            Thread.Sleep(4000);
            driver.FindElement(By.ClassName("gNO89b")).Click();
            Thread.Sleep(4000);
            String title = driver.Title;
            Console.WriteLine(driver.FindElement(By.Id("resultStats")));
            
            if(title==s)
            {
                Console.WriteLine("pass");
            }
            else
            {
                Console.WriteLine("fail");
            }
            driver.Close();
            Console.WriteLine(title);
            Console.WriteLine("Executed Successfully");
        }
    }
}
