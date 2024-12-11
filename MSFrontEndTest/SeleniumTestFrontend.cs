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
        public void CheckPageTitleSignUpUserFailTest()
        {

            _driver.Navigate().GoToUrl("http://127.0.0.1:5500/signUpForm.html");


            string pageTitleCreateUser = _driver.Title;


            Assert.AreEqual("Fail Test title", pageTitleCreateUser);

        }

        [TestMethod]
        public void CheckPageTitleLuftkontrol()
        {
           _driver.Navigate().GoToUrl("http://127.0.0.1:5500/index.html");

            string pageTitleLuftkontrol = _driver.Title;

            Assert.AreEqual("Luftkontrol", pageTitleLuftkontrol);
        }

        [TestMethod]
        public void CheckPageTitleLuftkontrolFailTest()
        {
            _driver.Navigate().GoToUrl("http://127.0.0.1:5500/index.html");

            string pageTitleLuftkontrol = _driver.Title;

            Assert.AreEqual("Fail Title Test", pageTitleLuftkontrol);
        }

        [TestMethod]
        public void SignUpFormTest()
        {
            _driver.Navigate().GoToUrl("http://127.0.0.1:5500/signUpForm.html");
            

            
            IWebElement emailInput = _driver.FindElement(By.Id("email"));
            emailInput.SendKeys("roman@example.com");

           
            IWebElement passwordInput = _driver.FindElement(By.Id("password"));
            passwordInput.SendKeys("123456");
            

            IWebElement confirmPasswordInput = _driver.FindElement(By.Id("confirmPassword"));
            confirmPasswordInput.SendKeys("123456");
            Assert.AreEqual(passwordInput.GetAttribute("value"), confirmPasswordInput.GetAttribute("value"));   

            
            IWebElement signUpButton = _driver.FindElement(By.CssSelector("button.btn.btn-success"));
            signUpButton.Click();

        }

        [TestMethod]
        public void SignUpFormTestFail()
        {
            _driver.Navigate().GoToUrl("http://127.0.0.1:5500/signUpForm.html");



            IWebElement emailInput = _driver.FindElement(By.Id("email"));
            emailInput.SendKeys("roman@example.com");


            IWebElement passwordInput = _driver.FindElement(By.Id("password"));
            passwordInput.SendKeys("123456");


            IWebElement confirmPasswordInput = _driver.FindElement(By.Id("confirmPassword"));
            confirmPasswordInput.SendKeys("223456");
            Assert.AreEqual(passwordInput.GetAttribute("value"), confirmPasswordInput.GetAttribute("value"));


            IWebElement signUpButton = _driver.FindElement(By.CssSelector("button.btn.btn-success"));
            signUpButton.Click();

        }








    }
}

