using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace УКТ_QA_1
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver Onedriver = new ChromeDriver();

            //1
            Onedriver.Url = "https://www.google.com/";

            //2
            Onedriver.Manage().Window.Maximize();

            //3 
            Onedriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            //4
            Onedriver.FindElement(By.XPath("/html/body/div/div[3]/form/div[2]/div[1]/div[1]/div/div[2]/input")).SendKeys("Youtube.com" + Keys.Enter);

            //5 
            Onedriver.FindElement(By.TagName("h3")).Click();

            //6
            Onedriver.FindElement(By.Name("search_query")).SendKeys("muhhamad ali im the greatest" + Keys.Enter);

            //7
            Onedriver.FindElement(By.XPath("/html/body/ytd-app/div/ytd-page-manager/ytd-search/div[1]/ytd-two-column-search-results-renderer/div/ytd-section-list-renderer/div[2]/ytd-item-section-renderer/div[3]/ytd-video-renderer[1]/div[1]/div/div[1]/div/h3/a/yt-formatted-string")).Click();

            //8
            Thread.Sleep(30000);

            //9 
            Onedriver.Quit();

        }
    }
}
