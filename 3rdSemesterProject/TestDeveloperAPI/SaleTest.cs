using Microsoft.AspNetCore.Identity;
using NUnit.Framework.Internal;
using System.Diagnostics.CodeAnalysis;
using WebApi.Controllers;
using WebApi.DataAccessLayer;
using WebApi.ModelLayer;
using WebMVC.Controllers;
using WebMVC.Models;

namespace TestAPI
{
    public class SaleTest
    {
        [SetUp]
        public void Setup()
        {
            
            
        }

        [Test]
        public void Test1()
        {
            //Necessary properties for test sale object, TimeAtTest to ensure equal values
            int GameID = 1;
            String Email = "test@gmail.com";
            float SalesPrice = 19;
            DateTime TimeAtTest = DateTime.Now;

            //Classes from API and MVC
            WebMVC.Controllers.SaleController scon = new WebMVC.Controllers.SaleController();
            WebApi.DataAccessLayer.SaleDataAccess sda = new SaleDataAccess("Data Source=hildur.ucn.dk;Initial Catalog=CSC-CSD-S212_10407565;User ID=csc-csd-s212_10407565;Password=Password1!");

            //Highest-level sale creation method from MVC, routes to WebApi.SaleDataAccess
            PartialSale TestPartialSale = new PartialSale(GameID, Email, SalesPrice);
            scon.CreateSale(TestPartialSale);

            //Makes an object from testing data as a point of comparison
            WebApi.ModelLayer.Sale TestSale = new WebApi.ModelLayer.Sale(GameID, Email, TimeAtTest, SalesPrice);

            //Gets the list of sales between TimeAtTest and current time (no significant difference),
            //which returns a single-item IEnumerable with the newly created test sale data
            IEnumerable<WebApi.ModelLayer.Sale> SalesFromDatabases = sda.SalesInPeriod(TimeAtTest,DateTime.Now);

            //Compares if the item in the IEnumerable is completely equal to the hardcoded test object
            Assert.That(SalesFromDatabases.First, Is.EqualTo(TestSale));
        }
    }
}