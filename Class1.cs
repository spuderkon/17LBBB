using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace _17LBB
{
    public class Class1
    {
        private readonly string url = "https://demoqa.com/";
        private readonly string urlelements = "https://demoqa.com/elements";
        private readonly By _elementsButton = By.XPath("/html/body/div[2]/div/div/div[2]/div/div[1]/div");
        private readonly By _textBoxButton = By.XPath("/html/body/div[2]/div/div/div[2]/div[1]/div/div/div[1]/div/ul/li[1]");
        private readonly By _wholeField = By.XPath("/html/body/div[2]/div/div/div[2]/div[2]");
        private readonly By _fullnameEntry = By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/form/div[1]/div[2]/input");
        private readonly By _emailEntry = By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/form/div[2]/div[2]/input");
        private readonly By _currentAddressEntry = By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/form/div[3]/div[2]/textarea");
        private readonly By _permanentAddreesEntry = By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/form/div[4]/div[2]/textarea");
        private readonly By _submitButton = By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/form/div[5]/div/button");
        private readonly By _hiddenField = By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/form/div[6]/div");
        private readonly By _checkBoxMenuButton = By.XPath("/html/body/div[2]/div/div/div[2]/div[1]/div/div/div[1]/div/ul/li[2]");
        private readonly By _checkBoxButton = By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div/ol/li/span/label");
        private readonly By _hiddenLabel = By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div[2]");
        private readonly By _webTablesMenuButton = By.XPath("/html/body/div[2]/div/div/div[2]/div[1]/div/div/div[1]/div/ul/li[4]");
        private readonly By _tableDeleteButton = By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div[3]/div[1]/div[2]/div[1]/div/div[7]/div/span[2]");
        private readonly By _fristTableDeleteButton = By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div[3]/div[1]/div[2]/div[1]/div/div[7]/div/span[2]");
        private readonly By _expectedValue = By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div[3]/div[1]/div[2]/div[1]/div/div[1]");
        private readonly By _changeButton = By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div[3]/div[1]/div[2]/div[1]/div/div[7]/div/span[1]");
        private readonly By _lastNameInput = By.XPath("/html/body/div[4]/div/div/div[2]/form/div[2]/div[2]/input");
        private readonly By _changeSubmitButton = By.XPath("/html/body/div[4]/div/div/div[2]/form/div[7]/div/button");
        private readonly By _lastNameField = By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div[3]/div[1]/div[2]/div[1]/div/div[2]");
        private readonly By _buttonsButton = By.XPath("/html/body/div[2]/div/div/div[2]/div[1]/div/div/div[1]/div/ul/li[5]");
        private readonly By _clickButton = By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div[3]/button");
        private readonly By _textField = By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/p");
        private readonly By _radioButtonMenu = By.XPath("/html/body/div[2]/div/div/div[2]/div[1]/div/div/div[1]/div/ul/li[3]");
        private readonly By _radioButtonImpressive = By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div[3]/label");
        private readonly By _impressiveField = By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/p/span");
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void SetUp()
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
        }

        [TestCase]
        public void MainTitle()
        {
            Assert.AreEqual("ToolsQA", driver.Title);
        }

        [TestCase]
        public void PushElementsButton()
        {
            RefreshToRootUrl();
            var elementsbutton = driver.FindElement(_elementsButton);
            elementsbutton.Click();
            //if (IsLoaded(_textBoxButton))
            //{
            //    var textboxbutton = driver.FindElement(_textBoxButton);
            //}
            Assert.AreEqual(urlelements, driver.Url);
        }

        [TestCase]
        public void FillForm()
        {
            driver.Url = urlelements;
            var textboxbutton = driver.FindElement(_textBoxButton);
            textboxbutton.Click();
            if (IsLoaded("/html/body/div[2]/div/div/div[2]/div[2]"))
            {
                var fullnameentry = driver.FindElement(_fullnameEntry);
                var emailentry = driver.FindElement(_emailEntry);
                var currentaddress = driver.FindElement(_currentAddressEntry);
                var permanentaddress = driver.FindElement(_permanentAddreesEntry);
                var submitbutton = driver.FindElement(_submitButton);
                fullnameentry.SendKeys("Mat");
                emailentry.SendKeys("example@example.com");
                currentaddress.SendKeys("somewhere in UK");
                permanentaddress.SendKeys("here");
                submitbutton.Click();
            }
            var hiddenfield = driver.FindElement(_hiddenField);
            bool examination = hiddenfield.Displayed;
            Assert.IsTrue(examination);
        }

        [TestCase]
        public void ClickCheckBoxButton()
        {
            driver.Url = urlelements;

            if (IsLoaded("/html/body/div[2]/div/div/div[2]/div[1]/div/div/div[1]/div/ul/li[2]"))
            {
                var checkbox = driver.FindElement(_checkBoxMenuButton);
                

                checkbox.Click();
                var checkboxbutton = driver.FindElement(_checkBoxButton);
                checkboxbutton.Click();
            }
            var hiddenLabel = driver.FindElement(_hiddenLabel);
            bool examination = hiddenLabel.Displayed;
            Assert.IsTrue(examination);
        }

        [TestCase]
        public void DeleteElementFromTable()
        {
            driver.Url=urlelements;           
            if (IsLoaded("/html/body/div[2]/div/div/div[2]/div[1]/div/div/div[1]/div/ul/li[4]"))
            {
                var webtablemenubutton = driver.FindElement(_webTablesMenuButton);
                webtablemenubutton.Click();
                var tabledeletebutton = driver.FindElement(_tableDeleteButton);
                tabledeletebutton.Click();
                var expectedvalue = driver.FindElement(_expectedValue);
                string expvalue = expectedvalue.Text;
                Assert.AreEqual("Alden",expvalue);
            }      
        }

        [TestCase]
        public void ChangeElementToTable()
        {
            driver.Url = urlelements;
            if (IsLoaded("/html/body/div[2]/div/div/div[2]/div[1]/div/div/div[1]/div/ul/li[4]"))
            {
                var webtablemenubutton = driver.FindElement(_webTablesMenuButton);
                webtablemenubutton.Click();
                var changebutton = driver.FindElement(_changeButton);
                changebutton.Click();
                if (IsLoaded("/html/body/div[4]/div/div"))
                {
                    var lastnameiniput = driver.FindElement(_lastNameInput);
                    lastnameiniput.SendKeys("lick");
                    var changesubmitbutton = driver.FindElement(_changeSubmitButton);
                    changesubmitbutton.Click();
                    var lastnamefield = driver.FindElement(_lastNameField);
                    string lastname = lastnamefield.Text;
                    Assert.AreEqual("Vegalick",lastname);
                }
            }
        }

        [TestCase]
        public void ClickButton()
        {
            driver.Url=urlelements;
            if (IsLoaded("/html/body/div[2]/div/div/div[2]/div[1]/div/div/div[1]/div/ul/li[5]"))
            {
                var buttonsButton = driver.FindElement(_buttonsButton);
                buttonsButton.Click();
                var doubleclickbutton = driver.FindElement(_clickButton);
                doubleclickbutton.Click();
                var textfield = driver.FindElement(_textField);
                string text = textfield.Text;
                Assert.AreEqual("You have done a dynamic click",text);
            }
        }

        [TestCase]
        public void RadioButton()
        {
            driver.Url = urlelements;
            if (IsLoaded("/html/body/div[2]/div/div/div[2]/div[1]/div/div/div[1]/div/ul/li[3]"))
            {
                var radiobutton = driver.FindElement(_radioButtonMenu);
                radiobutton.Click();
                var yesradiobutton = driver.FindElement(_radioButtonImpressive);
                yesradiobutton.Click();
                var yesField = driver.FindElement(_impressiveField);
                string yesfield = yesField.Text;
                Assert.AreEqual("Impressive",yesfield);
            }
        }
        [TearDown]
        public void TestEnd()
        {
            //driver.Quit();
        }
        public bool IsLoaded(string XPath)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));

            var element = wait.Until(condition =>
            {
                try
                {
                    var elementToBeDisplayed =
                    driver.FindElement(By.XPath(XPath));
                    return elementToBeDisplayed.Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });
            return element;
        }

        public void RefreshToRootUrl()
        {
            driver.Url = url;
        }
    }
}
