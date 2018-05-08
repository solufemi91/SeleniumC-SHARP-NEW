using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Selenium_C_Sharp;
using System.Linq;

namespace UnitTests
{

    class PageObjectModel
    {


        public static void Click_List_Departure()
        {
            IReadOnlyCollection<IWebElement> element = Program.driver.FindElements(By.ClassName("search-box-group__link"));
            element.ElementAt(0).Click();
        }

    }


    [TestFixture]
    public class MyFirstTest
    {
        [Test]
        public void TestDropDown()
        {
            
        }
    }


}
    