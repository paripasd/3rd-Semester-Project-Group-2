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

            //todo these methods don't exist in this version, winging it rn

            //variables used for testing
            int GameID = 100;


            Assert.That(ClientApp.RestClientLayer.FindGameFromID(GameID), Is.EqualTo(WebAPI.GameDataAccess.FindGameFromId(GameID)));
        }
    }
}