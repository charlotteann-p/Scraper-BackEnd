using System;
using System.IO;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Reflection.Metadata;
using OpenQA.Selenium.Html5;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Scraper 
{ 
    class Program
    {
        public static void Main(string[] args) 
        {
            RunScraper();
        }
        public static void RunScraper()
        {
            // Initialize the Chrome Driver
            IWebDriver driver = new ChromeDriver();
            using (driver)
            {
                YahooLogin(driver);
                FindTableValues(driver);
                MySqlConn();
            }
            driver.Quit();
        }
    }
}