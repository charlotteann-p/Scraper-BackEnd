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
    class FindStocks
    {
        public static void FindStockValues(IWebDriver driver)
        {
            IWebElement parentElement2 = driver.FindElement(By.TagName("tbody"));
            var rows = parentElement2.FindElements(By.TagName("tr"));
            foreach (var row in rows)
            {
                //var symbol = row.FindElement(By.TagName("td"));
                var tds = row.FindElements(By.TagName("td"));
                var symbol = tds[0].Text;
                var lastprice = tds[1].Text;
                var change = tds[2].Text;
                var chg = tds[3].Text;
                var currency = tds[4].Text;
                var markettime = tds[5].Text;
                var volume = tds[6].Text;
                var shares = tds[7].Text;
                var avgvol = tds[8].Text;
                var marketcap = tds[12].Text;

                //Console.WriteLine(symbol);
                //Console.WriteLine(lastprice);
                //Console.WriteLine(change);
                //Console.WriteLine(chg);
                //Console.WriteLine(currency);
                //Console.WriteLine(markettime);
                //Console.WriteLine(volume);
                //Console.WriteLine(shares);
                //Console.WriteLine(avgvol);
                //Console.WriteLine(marketcap);
                //Console.WriteLine("--------------------");
            }
        }
    }
}