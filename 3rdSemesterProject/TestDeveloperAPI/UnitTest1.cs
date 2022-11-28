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
            Game testGame = new Game(1, "TestGame", "Test game", 2011, "dfdsfs","FPS", 19, "testgame.exe",new byte[] { });
            GameDataAccess gda = new GameDataAccess();
            Assert.IsTrue(gda.DeleteGame(23));
        }
    }
}