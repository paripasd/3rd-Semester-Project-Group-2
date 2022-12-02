using Microsoft.AspNetCore.Identity;
using NUnit.Framework.Internal;
using WebApi.Controllers;
using WebApi.DataAccessLayer;
using WebApi.ModelLayer;

namespace TestDeveloperAPI
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
            
        }

        [Test]
        public void Test1()
        {

            Event e = new Event();
            e.GameID = 10;
            e.Name = "Test Event";
            e.Description = "Cool event";
            e.Capacity = 10;
            e.StartDate = new DateTime(2022, 5, 1, 8, 0, 0);
            e.EndDate = new DateTime(2022, 12, 5, 10, 0, 0, 0);
            
            EventDataAccess eventDataAccess = new EventDataAccess("Data Source=hildur.ucn.dk;Initial Catalog=CSC-CSD-S212_10407565;User ID=csc-csd-s212_10407565;Password=Password1!");
            eventDataAccess.CreateEvent(e);
            Assert.AreEqual(e, e);
        }
    }
}