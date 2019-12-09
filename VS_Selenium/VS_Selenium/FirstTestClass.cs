using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome; // Added Explicitly

using System.Text;

namespace VS_Selenium
{
    [TestClass]
    public class FirstTestClass
    {
        // private IWebDriver driver;

        [TestMethod]
        public void TheBulletinChromeMethod()
        {
            IWebDriver driver = new ChromeDriver();
            // To maximize Window and close it
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://bulletin.uga.edu/");
            driver.FindElement(By.Name("majors")).Click();
            driver.FindElement(By.Id("ddlAllMajors")).Click();
            new SelectElement(driver.FindElement(By.Id("ddlAllMajors"))).SelectByText("African American Studies - A.B.");
            driver.FindElement(By.Id("ddlAllMajors")).Click();
            driver.FindElement(By.Id("Imgbut_go_offAllMajors")).Click();


            // WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            // wait.Until(ExpectedConditions.ElementExists((By.Id("lnkBtnMajorReq"))).click();

            new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists((By.Id("lnkBtnMajorReq")))).Click();


            // driver.FindElement(By.Id("lnkBtnMajorReq")).Click();
            //  = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.FindElement(By.Id("pnlMajorReqSummaryNoShow")).Click();
            driver.FindElement(By.LinkText("Entrance Requirements for the Major")).Click();


            driver.Close();
            driver.Quit();
        }
    }
}
