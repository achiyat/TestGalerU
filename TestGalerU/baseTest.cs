using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;
using System.Xml.Linq;

namespace automation
{
    internal abstract class baseTest
    {
        protected IWebDriver driver;

        public void pause(int mili = 2000) { System.Threading.Thread.Sleep(mili); }

        public void run(string _url)
        {
            string url = _url;
            using (driver = new ChromeDriver())
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

                // Go To Url
                try
                {
                    driver.Navigate().GoToUrl(url);
                    pause();
                    //wait.Until<int>((d) => { driver.Navigate().GoToUrl(url); return 0; });
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }

                // Click Log In
                try
                {
                    IWebElement element = findClass("button-0-2-2");
                    if (element != null) { element.Click(); }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }

                int a = 0;
                driver.Quit();
            }
        }

        public void run1(string _url, string email, string password)
        {
            string url = _url;
            using (driver = new ChromeDriver())
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

                // Go To Url
                try
                {
                    driver.Navigate().GoToUrl(url);
                    pause();
                    //wait.Until<int>((d) => { driver.Navigate().GoToUrl(url); return 0; });
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }

                // Click Log In
                try
                {
                    IWebElement element = findClass("button-0-2-2");
                    if (element != null) { element.Click(); }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }

                // input email
                try
                {
                    IWebElement element = findId("username");
                    if (element != null) { element.SendKeys(email); }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }

                // Click Continue
                try
                {
                    // IWebElement element = findPartialText("Continue");
                    
                    IWebElement element = findClass("_button-login-id");
                    if (element != null) { element.Click(); }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }

                // input password
                try
                {
                    IWebElement element = findId("password");
                    if (element != null) { element.SendKeys(password); }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); driver.Quit(); MessageBox.Show("Email is not valid"); }

                // Click Continue
                try
                {
                    // IWebElement element = findPartialText("Continue");

                    IWebElement element = findClass("_button-login-password");
                    if (element != null) { element.Click(); }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }

                pause();
                string urlAfterSignUp = driver.Url;
                if (driver.Url == "https://blue-field-01c0eaf03.3.azurestaticapps.net/")
                {
                    driver.Quit(); MessageBox.Show("Welcome, you have been successfully logged in!");
                }
                else
                { driver.Quit(); MessageBox.Show("Wrong password"); }
                
            }
        }

        public void LoginWithGoogle(string _url, string email, string password)
        {
            string url = _url;
            using (driver = new ChromeDriver())
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

                // Go To Url
                try
                {
                    driver.Navigate().GoToUrl(url);
                    pause();
                    //wait.Until<int>((d) => { driver.Navigate().GoToUrl(url); return 0; });
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }

                // Click Log In
                try
                {
                    IWebElement element = findClass("button-0-2-2");
                    if (element != null) { element.Click(); }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }

                // Click Continue
                try
                {
                    IWebElement element = findCssSelector("button[data-provider='google']");
                    if (element != null) { element.Click(); }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }

                // input email
                try
                {
                    IWebElement element = findId("identifierId");
                    if (element != null) { element.SendKeys(email); }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }

                // Click button "הבא"
                try
                {
                    IWebElement element = findPartialText("הבא");
                    if (element != null) { element.Click(); }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }

                // בהמשך, לבדוק האם נכנס או לא

                int a = 0;
                driver.Quit();
            }
        }

        public void SignUp(string _url, string email, string password)
        {
            string url = _url;
            using (driver = new ChromeDriver())
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

                // Go To Url
                try
                {
                    driver.Navigate().GoToUrl(url);
                    pause();
                    //wait.Until<int>((d) => { driver.Navigate().GoToUrl(url); return 0; });
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }

                // Click Log In
                try
                {
                    IWebElement element = findClass("button-0-2-2");
                    if (element != null) { element.Click(); }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }

                // Click Sign up
                try
                {
                    IWebElement element = findPartialText("Sign up");
                    if (element != null) { element.Click(); }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }

                // input email
                try
                {
                    IWebElement element = findId("email");
                    if (element != null) { element.SendKeys(email); }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }

                // Click Continue
                try
                {
                    // IWebElement element = findPartialText("Continue");

                    IWebElement element = findClass("_button-signup-id");
                    if (element != null) { element.Click(); }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }

                // input password
                try
                {
                    IWebElement element = findId("password");
                    if (element != null) { element.SendKeys(password); }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); driver.Quit(); MessageBox.Show("Email is not valid"); }

                // Click Continue
                try
                {
                    // IWebElement element = findPartialText("Continue");

                    IWebElement element = findClass("cef29ae8c");
                    if (element != null) { element.Click(); }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }

                // Password check
                try
                {
                    IWebElement element = findId("prompt-alert");
                    if (element != null) 
                    {
                        driver.Quit(); MessageBox.Show("The user already exists!");
                    }
                }
                catch (Exception ex) 
                {
                    pause();
                    if (driver.Url == "https://blue-field-01c0eaf03.3.azurestaticapps.net/")
                    {
                        driver.Quit(); MessageBox.Show("Welcome, you have been successfully logged in!");
                    }
                    else
                    {
                        driver.Quit(); MessageBox.Show("Your password must contain:\r\nAt least 8 characters\r\nAt least 3 of the following:\r\nLower case letters (a-z)\r\nUpper case letters (A-Z)\r\nNumbers (0-9)\r\nSpecial characters (e.g. !@#$%^&*)");
                    }
                }
            }
        }

        public abstract IWebElement findClass(string ByString);
        public abstract IWebElement findId(string ByString);
        public abstract IWebElement findPartialText(string ByString);
        public abstract IWebElement findCssSelector(string ByString);
    }


}

// string password
// //
//https://blue-field-01c0eaf03.3.azurestaticapps.net/