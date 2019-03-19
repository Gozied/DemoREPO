using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using UnitTestProject1.Settings;

namespace UnitTestProject1.ComponentHelper
{
    public class GenericHelper
    {
        public static bool IstheElementPresent(By locator)
        {
            try
            {
                return ObjectRepository.Driver.FindElements(locator).Count == 1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static IWebElement GetElement(By locator)
        {
            if (IstheElementPresent(locator))
            {
                return ObjectRepository.Driver.FindElement(locator);

            }
            else
            {
                throw new NoSuchElementException("Elemt is not present" + locator.ToString());
            }
        }

        public static void TakeScreenShot(string errorShot = "Error")
        {
            var screenshot = ObjectRepository.Driver.TakeScreenshot();
            Directory.CreateDirectory("screenshots");
            errorShot = $"{DateTime.Now:dd.MM.yyyy-HH.mm.ss}.jpeg";
            screenshot.SaveAsFile("screenshots\\" + ObjectRepository.Driver.Title + "--" + errorShot, ScreenshotImageFormat.Jpeg);
        }
    }
}
