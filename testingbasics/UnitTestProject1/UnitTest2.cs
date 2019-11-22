using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace UnitTestProject1
{

    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void sUnitTest2()
        {
            IWebDriver driver;
            driver = new ChromeDriver("C:\\SeleniumJar");
            string url = "http://www.youcandealwithit.com/";
            driver.Url = url;

            IWebElement calres=driver.FindElement(By.XPath("//a[text()='Borrowers']"));
            Actions action = new Actions(driver);
            action.MoveToElement(calres).Build().Perform();
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//*[text()='Calculators & Resources']")).Click();
            Thread.Sleep(4000);
            String title1 = driver.Title;
            string click1 = "Calculators & Resources";
            if(title1== click1)
            {
                Console.WriteLine(" calculator and resources pass");
            }
            else
            {
                Console.WriteLine("calculator and resources fail");
            }
            driver.FindElement(By.XPath("//*[text()='Calculators']")).Click();
            Thread.Sleep(4000);
            String title2 = driver.Title;
            string click2 = "Calculators";
            if (title2 == click2)
            {
                Console.WriteLine(" calculators pass");
            }
            else
            {
                Console.WriteLine("calculators fail");
            }
            driver.FindElement(By.XPath("//*[text()='Budget Calculator']")).Click();
            Thread.Sleep(4000);
            String title3 = driver.Title;
            string click3 = "Budget Calculator";
            if (title3 == click3)
            {
                Console.WriteLine("Budget calculator pass");
            }
            else
            {
                Console.WriteLine("Budget calculator fail");
            }
            string food = "4000";
            string clothing = "5000";
            string shelter = "7000";
            string monthlyother = "3000";
            string monthlypay = "30000";
            driver.FindElement(By.Id("food")).SendKeys(food);
            driver.FindElement(By.Id("clothing")).SendKeys(clothing);
            driver.FindElement(By.Id("shelter")).SendKeys(shelter);
            driver.FindElement(By.Id("monthlyOther")).SendKeys(monthlyother);
            driver.FindElement(By.Id("monthlyPay")).SendKeys(monthlypay);
            string monthlyexpenses=(driver.FindElement(By.Id("totalMonthlyExpenses")).GetAttribute("value"));
            string totalpay = (driver.FindElement(By.Id("totalMonthlyIncome")).GetAttribute("value"));
            Console.WriteLine(monthlyexpenses);
            if (Convert.ToDouble(monthlyexpenses) >= Convert.ToDouble(totalpay))
            {
                Console.WriteLine("you are waren buffet");
            }
           else
            {
                Console.WriteLine("you are VM");
            }





            driver.Close();
            Console.WriteLine("Executed Successfully");

        }

       
    }
}
