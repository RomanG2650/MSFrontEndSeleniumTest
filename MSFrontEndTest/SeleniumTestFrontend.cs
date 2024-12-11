using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace MSFrontEndTest
{
    [TestClass]
    public class SeleniumTestFrontend
    {
        private static readonly string DriversDirectory = "C:/Users/PC/OneDrive/Dokumenter/ChromeDriverFrontEnd";
        private static IWebDriver _driver;

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            _driver = new ChromeDriver(DriversDirectory);
            // _driver = new FirefoxDriver(DriverDirectory);  
            //_driver = new EdgeDriver(DriverDirectory);
        }

        [ClassCleanup]
        public static void TearDown()
        {
            _driver.Dispose();
        }

        [TestMethod]
        public void CheckPageTitleSignUpUser()
        {

            _driver.Navigate().GoToUrl("http://127.0.0.1:5500/signUpForm.html");


            string pageTitleCreateUser = _driver.Title;
            

            Assert.AreEqual("Create User", pageTitleCreateUser);
           
        }

        [TestMethod]
        public void CheckPageTitleLuftkontrol()
        {
           _driver.Navigate().GoToUrl("http://127.0.0.1:5500/index.html");

            string pageTitleLuftkontrol = _driver.Title;

            Assert.AreEqual("Luftkontrol", pageTitleLuftkontrol);
        }
        
       

     

        



    }
}

