using Microsoft.AspNetCore.Identity;
using NUnit.Framework.Internal;
using System.Diagnostics.CodeAnalysis;
using ClientApp.ModelLayer;
using ClientApp.RestClientLayer;
using WebAPI.DataAccessLayer;

namespace TestAPI
{
    public class TestDeleteGame
    {
        [SetUp]
        public void Setup()
        {


        }

        [Test]
        public void Test1()
        {
            //variables used for testing
            int GameID = 100;

            ClientApp.RestClientLayer.DeleteGame(GameID);

            Assert.That(null, Is.EqualTo(WebAPI.GameDataAccess.FindGameFromId(GameID)));
        }
    }
}