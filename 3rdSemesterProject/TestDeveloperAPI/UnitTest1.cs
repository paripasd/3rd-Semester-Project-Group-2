using Microsoft.AspNetCore.Identity;
using NUnit.Framework.Internal;
using WebApi.Controllers;
using WebApi.DataAccessLayer;
using WebApi.ModelLayer;


namespace TestAPI
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
            IEnumerable<int> test = new List<int>();
            test.Append(2);
            EventMemberDataAccess eventMemberDataAccess = new EventMemberDataAccess("Data Source=hildur.ucn.dk;Initial Catalog=CSC-CSD-S212_10407565;User ID=csc-csd-s212_10407565;Password=Password1!");
            IEnumerable<int> list = eventMemberDataAccess.GetMemberIdListByEventId(10);
            Assert.AreEqual(test, list);
        }
    }
}