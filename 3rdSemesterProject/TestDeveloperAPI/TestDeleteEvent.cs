using Microsoft.AspNetCore.Identity;
using NUnit.Framework.Internal;
using System.Diagnostics.CodeAnalysis;
using ClientApp.ModelLayer;
using ClientApp.RestClientLayer;
using WebAPI.DataAccessLayer;

namespace TestAPI
{
    public class TestDeleteEvent
    {
        [SetUp]
        public void Setup()
        {


        }

        [Test]
        public void Test1()
        {
            //variables used for testing
            int EventID = 100;

            ClientApp.RestClientLayer.DeleteEvent(eventID);

            Assert.That(null, Is.EqualTo(WebAPI.EventDataAccess.FindEventFromId(EventID)));
        }
    }
}