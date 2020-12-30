using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumAdvancedFW
{
    public class Tests:DriverHelper
    {



        [SetUp]
        public void Setup()
        {
            Console.WriteLine("SetUp");
            Driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");


            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");

            CustomControls.comboBox("ContentPlaceHolder1_AllMealsCombo", "Almond");

            Console.WriteLine("TearDown");
            Assert.Pass();
        }
    }
}