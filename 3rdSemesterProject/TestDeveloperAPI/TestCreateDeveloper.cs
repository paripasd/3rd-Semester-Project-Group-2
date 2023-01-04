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
    public class TestCreateDeveloper
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
            string name = "TestDev";
            string email = "td@gmail.com";
            string description = "Dev for testing method";
            //new instance to be used for comparison
            Developer d= new Developer(devID,name,email,description);
            

            ClientApp.RestClientLayer.CreateDeveloper(d);

            Assert.That(d, Is.EqualTo(WebAPI.DeveloperDataAccess.FindDeveloperFromId(devID)));
        }
    }
}

