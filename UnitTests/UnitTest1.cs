using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Selenium_C_Sharp;
using System.Linq;
using OpenQA.Selenium.Chrome;

namespace UnitTests
{

    class PageObjectModel
    {
        public static void Launch_Page()
        { 
            Program.driver.Navigate().GoToUrl("https://www.jet2holidays.com/");
        }

        public static void ClickPopUp()
        {
            IReadOnlyCollection<IWebElement> element = Program.driver.FindElements(By.ClassName("j017-close-lightbox"));
            element.ElementAt(0).Click();
        }


        public static void Click_List_Departure()
        {
            IReadOnlyCollection<IWebElement> element = Program.driver.FindElements(By.ClassName("search-box-group__link"));
            element.ElementAt(0).Click();
        }

        public static bool Check_Choose_departure_modal()
        {
            bool holder = false;
            IReadOnlyCollection<IWebElement> elements = Program.driver.FindElements(By.XPath("//*[@class='modal-box__heading']"));
            foreach (IWebElement element in elements)
            {
                if (element.Text.Contains("Choose departure"))

                {
                    holder = element.Displayed;
                }
            }
            return holder;
        }


    }

    [TestFixture]
    public class MyFirstTest
    {
        [Test]
        public void TestDropDown()
        {
            PageObjectModel.Launch_Page();
            PageObjectModel.ClickPopUp();
            PageObjectModel.Click_List_Departure();
        }
    }



    [TestFixture]
    public class MySecondTest
    {
        [Test]
        public void TestModalAppears()
        {
           bool holder = PageObjectModel.Check_Choose_departure_modal();
            NUnit.Framework.Assert.That(holder, Is.EqualTo(true));
        }
    }


}
    