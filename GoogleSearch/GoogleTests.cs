using System;
using NUnit.Framework;

namespace GoogleSearch
{
    public class GoogleTests : BaseTest
    {
        private String url = "https://www.google.com";
        private String searchText = "Selenium IDE export to C#";
        private int index = 3;
        private String expectedText = "Selenium IDE";


        [Test]
        public void Test()
        {
            String actualText;
            app.driver.Navigate().GoToUrl(url);
            GoogleSearchPage googleSearchPage = new GoogleSearchPage(app.driver);
            googleSearchPage.SendTextToSearch(searchText);
            googleSearchPage.ClickSearchSubmitButton();
            actualText = googleSearchPage.GetTextOfResults(index);
            Assert.IsTrue(expectedText.Contains(actualText), "Expected text isn't exist in actual text");
        }
    }
}