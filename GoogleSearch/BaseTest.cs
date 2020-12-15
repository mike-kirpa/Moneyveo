using System;
using NUnit.Framework;

namespace GoogleSeach
{
    [TestFixture]
    public class BaseTest
    {
        public ApplicationManager app = new ApplicationManager();

        [SetUp]
        public void StartDriver()
        {
            app.init();
        }

        [TearDown]
        public void CloseDriver()
        {
            app.stop();
        }
    }
}