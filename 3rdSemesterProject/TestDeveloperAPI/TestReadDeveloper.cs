using Microsoft.AspNetCore.Identity;
using NUnit.Framework.Internal;
using System.Diagnostics.CodeAnalysis;
using ClientApp.ModelLayer;
using ClientApp.RestClientLayer;
using WebAPI.DataAccessLayer;

namespace TestAPI
{
    public class TestReadDeveloper
    {
        [SetUp]
        public void Setup()
        {


        }

        [Test]
        public void Test1()
        {
            //variables used for testing
            int DevID = 100;


            Assert.That(ClientApp.RestClientLayer.FindDeveloperFromID(DevID), Is.EqualTo(WebAPI.DeveloperDataAccess.FindDeveloperFromId(DevID)));
        }
    }
}