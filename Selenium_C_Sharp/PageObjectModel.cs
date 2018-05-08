using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_C_Sharp
{
    public  class  PageObjectModel { 


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

        

        public static void Click_List_Arrival()
        {
            IReadOnlyCollection<IWebElement> element = Program.driver.FindElements(By.ClassName("search-box-group__link"));
            element.ElementAt(1).Click();
        }

        public static void Click_Departure_Airport(String Location)
        {
            IReadOnlyCollection<IWebElement> elements = Program.driver.FindElements(By.ClassName("checkbox-button-group__item"));
            foreach(IWebElement element in elements)
            {
                if (element.Text.Contains(Location))

                {
                    Actions actions = new Actions(Program.driver);
                    actions.MoveToElement(element);
                    element.Click();
                }
            }
        }

        public static void Random_Click_Departure_Airport()
        {
            IReadOnlyCollection<IWebElement> elements = Program.driver.FindElements(By.ClassName("checkbox-button-group__item"));
            
            Random rnd = new Random();
            int RandomInt = rnd.Next(9);
            
            IWebElement Airport = elements.ElementAt(RandomInt);
            
            
            Actions actions = new Actions(Program.driver);
            actions.MoveToElement(Airport);
            Airport.Click();
            
            
        }

        public static void Click_Arrival_Airport(String Location)
        {
            IReadOnlyCollection<IWebElement> elements = Program.driver.FindElements(By.ClassName("checkbox-button-group__item--indent"));
            foreach (IWebElement element in elements)
            {
                if (element.Text.Contains(Location))

                {
                    Actions actions = new Actions(Program.driver);
                    actions.MoveToElement(element);
                    element.Click();
                }
            }
        }

        public static void Click_Date_Dropdown()
        {
            IWebElement element = Program.driver.FindElement(By.Id("search-box-leaving"));
            element.Click();
        }

        public static void Select_Month(String Month)
        {
            IWebElement element = Program.driver.FindElement(By.Id("duration-month"));
            IReadOnlyCollection<IWebElement> options = element.FindElements(By.TagName("option"));
            foreach(IWebElement option in options)
            {
                String holder = option.Text;
                if (holder.Contains(Month))
                {
                    Actions actions = new Actions(Program.driver);
                    actions.MoveToElement(option);
                    option.Click();
                }
            }
        }

        public static void Select_Day(String Day)
        {
            IReadOnlyCollection<IWebElement> elements = Program.driver.FindElements(By.ClassName("js-day"));
            foreach (IWebElement element in elements)
            {
                if (element.Text == Day)
                {
                    Actions actions = new Actions(Program.driver);
                    actions.MoveToElement(element);
                    element.Click();
                }
            }
        }


        public static void New_Select_Day()
        {
            int i = 0;
            int x = 0;
            String[] Months = new String[10] {"Mar","Apr", "May", "Jun","Jul", "Aug", "Sep","Oct", "Nov", "Dec"};
            
            do
            {
                Select_Month(Months[x]);
                IReadOnlyCollection<IWebElement> elements = Program.driver.FindElements(By.ClassName("js-day"));
   
            
            
                foreach (IWebElement element in elements)
                {

                   IWebElement DivElement = element.FindElement(By.TagName("div"));

                   if (!DivElement.GetAttribute("Class").Contains("is-disabled") && i == 0) 
                   {
                       Actions actions = new Actions(Program.driver);
                       actions.MoveToElement(DivElement);
                       DivElement.Click();
                       i++;
                   }
                }
                
                x++;
                
                
                
            } while (i == 0 || x < 9);
            
        }

        public static void Select_Nights(int Nights)
        {
            IWebElement element = Program.driver.FindElement(By.Id("search-box-nights"));
            element.Click();
            IReadOnlyCollection<IWebElement> options = element.FindElements(By.TagName("option"));
            options.ElementAt(Nights).Click();
        }

        public static void Find_Holiday()
        {
            IReadOnlyCollection<IWebElement> elements = Program.driver.FindElements(By.ClassName("search-box__submit"));
            elements.ElementAt(0).Click();
            
        }


    }
}
