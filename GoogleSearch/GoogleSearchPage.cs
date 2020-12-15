using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;

namespace GoogleSearch
{
    public class GoogleSearchPage
    {
        private readonly IWebDriver driver;
        private readonly String url = "www.google.com";
        public GoogleSearchPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        
        public IWebElement SearchField 
        {
            get
            {
                return driver.FindElement(By.Name("q"));
            }
        }
        
        public void SendTextToSearch(string textToType)
        {
            SearchField.Clear();
            SearchField.SendKeys(textToType);
        }

        public void ClickSearchSubmitButton()
        {
            SearchField.Submit();
        }

        public String GetTextOfResults(int index)
        {
            IReadOnlyCollection<IWebElement> results = driver.FindElements(By.XPath("//div[@class=\"g\"]/div/div/a/h3/span"));
            var textResult = results.ElementAt(index);
            return textResult.Text;
        }
        
        
    }
}