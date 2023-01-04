using Microsoft.AspNetCore.Identity;
using NUnit.Framework.Internal;
using System.Diagnostics.CodeAnalysis;
using ClientApp.ModelLayer;
using ClientApp.RestClientLayer;
using WebAPI.DataAccessLayer;

namespace TestAPI
{
    public class TestReadEvent
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


            Assert.That(ClientApp.RestClientLayer.FindEventFromID(EventID), Is.EqualTo(WebAPI.EventDataAccess.FindEventFromId(EventID)));
        }
    }
}