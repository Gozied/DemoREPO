using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using UnitTestProject1.Configuration;
using UnitTestProject1.CostomExeption;
using UnitTestProject1.Settings;

namespace UnitTestProject1.BaseClass
{
    [TestClass]
    public class TestBaseClass
    {

        #region BrowserOptions

        private static ChromeOptions GetChromeOptions()
        {
            var cOptions = new ChromeOptions();
            cOptions.AddArgument("start-maximized");
            return cOptions;
        }

        //headless mode
        private static IWebDriver GetExtraChromeDriver()
        {
            IWebDriver driver = new ChromeDriver(GetMoreChromeOption());
            return driver;
        }
        private static InternetExplorerOptions GetIEOptions()
        {
            var iEOptions = new InternetExplorerOptions();
            {
                iEOptions.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                iEOptions.EnsureCleanSession = true;

            }
            return iEOptions;
        }

        private static FirefoxProfile GetFireFoxOptions()
        {
            var fOptions = new FirefoxProfile();
            var fxManager = new FirefoxProfileManager();
            fOptions = fxManager.GetProfile("default");
            return fOptions;
        }

        private static ChromeOptions GetMoreChromeOption()
        {
            var mChromeOptions = new ChromeOptions();
            mChromeOptions.AddArgument("--headless");
            return mChromeOptions;
        }
        
        #endregion


  #region DriverInstances




        private static IWebDriver GetFireFoxDriver()
        {
            IWebDriver driver = new FirefoxDriver();
            return driver;
        }

        private static IWebDriver GetIEDriver()
        {
            IWebDriver driver = new InternetExplorerDriver(GetIEOptions());
            return driver;
        }

        private static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver(GetChromeOptions());
            return driver;
        }
#endregion       
        
#region  BrowserLuch 
        [AssemblyInitialize]
        public static void InitWebDriver(TestContext testContext)
        {
            ObjectRepository.Config = new AppConfigReader();
            switch (ObjectRepository.Config.GetBrowser())
            {
                case BrowserType.FireFox:
                    ObjectRepository.Driver = GetFireFoxDriver();
                    break;
                case BrowserType.Chrome:
                    ObjectRepository.Driver = GetChromeDriver();
                    break;
                case BrowserType.Explorer:
                    ObjectRepository.Driver = GetIEDriver();
                    break;
                case BrowserType.ChromeHeadless:
                    ObjectRepository.Driver = GetExtraChromeDriver();
                    break;
                default:
                    throw new NoSuitableDriverFound("Driver not found {0}", ObjectRepository.Config.GetBrowser());
            }
             ObjectRepository.Driver.Manage().Timeouts().PageLoad= TimeSpan.FromSeconds(15);
        }
#endregion
    }

}
