using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SoftwareQualityAndTesting.Tests
{
    [TestFixture]
    public class TestClass
    {
        static CalcPremiumClass c1;
        IWebDriver driverGC;
        IWebDriver driverFF;
        
        [SetUp]
        public void Init()
        {
            c1 = new CalcPremiumClass();
            driverGC = new ChromeDriver();
            driverFF = new FirefoxDriver(@"C:\Users\jamie\Source\Repos\SoftwareQualityAndTesting\SoftwareQualityAndTesting");
        }

        [Test]
        public void ChromeMale35Website()
        {
            driverGC.Navigate().GoToUrl("http://localhost:13748/Input.aspx");
            driverGC.FindElement(By.Id("txtGender")).SendKeys("male");
            driverGC.FindElement(By.Id("txtAge")).SendKeys("35");
            driverGC.FindElement(By.Id("btnSubmit")).SendKeys(Keys.Enter);
        }

        [Test]
        public void ChromeMale55Website()
        {
            driverGC.Navigate().GoToUrl("http://localhost:13748/Input.aspx");
            driverGC.FindElement(By.Id("txtGender")).SendKeys("male");
            driverGC.FindElement(By.Id("txtAge")).SendKeys("55");
            driverGC.FindElement(By.Id("btnSubmit")).SendKeys(Keys.Enter);
        }

        [Test]
        public void ChromeTypo16Website()
        {
            driverGC.Navigate().GoToUrl("http://localhost:13748/Input.aspx");
            driverGC.FindElement(By.Id("txtGender")).SendKeys("famale");
            driverGC.FindElement(By.Id("txtAge")).SendKeys("16");
            driverGC.FindElement(By.Id("btnSubmit")).SendKeys(Keys.Enter);
        }

        [Test]
        public void ChromeFemale24Website()
        {
            driverGC.Navigate().GoToUrl("http://localhost:13748/Input.aspx");
            driverGC.FindElement(By.Id("txtGender")).SendKeys("female");
            driverGC.FindElement(By.Id("txtAge")).SendKeys("24");
            driverGC.FindElement(By.Id("btnSubmit")).SendKeys(Keys.Enter);
        }

        [Test]
        public void FirefoxWebsite()
        {
            driverFF.Navigate().GoToUrl("http://localhost:13748/Input.aspx");
            driverFF.FindElement(By.Id("txtGender")).SendKeys("male");
            driverFF.FindElement(By.Id("txtAge")).SendKeys("35");
            driverFF.FindElement(By.Id("btnSubmit")).SendKeys(Keys.Enter);
        }

        [TearDown]
        public void CloseBrowser()
        {
            driverGC.Close();
            driverFF.Close();
        }

        [Test(Description = "Test check not null")]
        public void CheckObject() => Assert.NotNull(c1, "Object not created");

        [TestCase(16, "female", ExpectedResult = 0)]
        [TestCase(27, "female", ExpectedResult = 5)]
        [TestCase(35, "female", ExpectedResult = 2.5)]
        [TestCase(55, "female", ExpectedResult = 0.375)]
        [TestCase(16, "male", ExpectedResult = 0)]
        [TestCase(33, "male", ExpectedResult = 6)]
        [TestCase(38, "male", ExpectedResult = 5)]
        [TestCase(53, "male", ExpectedResult = 0.75)]
        [TestCase(25, "mile", ExpectedResult = 0)]
        [TestCase(52, "famele", ExpectedResult = 0)]
        public float CheckPremium(int age, string gender)
        {
            float actualResult = c1.CalcPremium(age, gender);
            return actualResult;
        }
    }
}
