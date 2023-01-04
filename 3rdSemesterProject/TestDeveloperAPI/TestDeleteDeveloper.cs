using Microsoft.AspNetCore.Identity;
using NUnit.Framework.Internal;
using System.Diagnostics.CodeAnalysis;
using ClientApp.ModelLayer;
using ClientApp.RestClientLayer;
using WebAPI.DataAccessLayer;

namespace TestAPI
{
    public class TestDeleteDeveloper
    {
        [SetUp]
        public void Setup()
        {


        }

        [Test]
        public void Test1()
        {
            //variables used for testing
            int devID = 100;
 
            ClientApp.RestClientLayer.DeleteDeveloper(devID);

            Assert.That(null, Is.EqualTo(WebAPI.DeveloperDataAccess.FindDeveloperFromId(devID)));
        }
    }
}