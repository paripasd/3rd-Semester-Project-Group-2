using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using NUnit.Framework.Internal;
using System.Diagnostics.CodeAnalysis;
using ClientApp.ModelLayer;
using ClientApp.RestClientLayer;
using WebAPI.DataAccessLayer;

namespace TestAPI
{
    public class TestUpdateEvent
    {
        [SetUp]
        public void Setup()
        {


        }

        [Test]
        public void Test1()
        {
            //variables used for testing
            int eventId = 100;
            int gameId = 1;
            string name = "TestUpdatedEvent";
            string description = "Updated Event for testing method";
            DateTime startDate = new DateTime(2022, 12, 24, 15, 00, 00);
            DateTime endDate = new DateTime(2023, 12, 24, 15, 00, 00);
            int capacity = 20;
            //new instance to be used for comparison
            Event e = new Event(eventId, gameId, name, description, startDate, endDate, capacity);


            ClientApp.RestClientLayer.UpdateEvent(e);

            Assert.That(e, Is.EqualTo(WebAPI.EventDataAccess.FindEventFromId(eventID)));
        }
    }
}
