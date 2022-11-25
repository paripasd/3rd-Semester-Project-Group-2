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
            Developer david = new Developer(1,"David", "paripasd@gmail.com", "Cool developer");
            DeveloperDataAccess dda = new DeveloperDataAccess();
            DeveloperController developerController = new DeveloperController(dda);
            Assert.AreEqual(david.Description, dda.FindDeveloperFromId(1).Description);
        }
    }
}