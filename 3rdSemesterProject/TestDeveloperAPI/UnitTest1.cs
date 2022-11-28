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
			byte[] fileBytes = System.IO.File.ReadAllBytes("Archive.zip");
			Game testGame = new Game(1, 1, "testing data", "testing", 3333, "asdg", "fps", 29, "Archive.zip", fileBytes);
			GameDataAccess gda = new GameDataAccess("Data Source=hildur.ucn.dk;Initial Catalog=CSC-CSD-S212_10407565;User ID=csc-csd-s212_10407565;Password=Password1!");
            Assert.IsTrue(gda.CreateGame(testGame));
        }
    }
}