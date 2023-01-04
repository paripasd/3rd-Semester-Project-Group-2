﻿using Microsoft.AspNetCore.Identity;
using NUnit.Framework.Internal;
using System.Diagnostics.CodeAnalysis;
using ClientApp.ModelLayer;
using ClientApp.RestClientLayer;
using WebAPI.DataAccessLayer;

namespace TestAPI
{
    public class TestCreateGame
    {
        [SetUp]
        public void Setup()
        {


        }

        [Test]
        public void Test1()
        {
            //todo some methods don't exist in this version, this is pure bs (esp line 36)

            //variables used for testing
            int gameID = 100;
            int devID = 1;
            string title = "TestUpdatedGame";
            string description = "Updated Game for testing method";
            int YOR = 2023;
            string specs = "Updated Testing data";
            string type = "TestPS";
            float price = 300;
            //new instance to be used for comparison
            Game g = new Game(gameID, devID, title, description, YOR, specs, type, price);
            GameFile gf = new GameFile("TestUpdatedTitle", 5);
            ClientApp.RestClientLayer.UpdateGame(g, gf);

            Assert.That(g, Is.EqualTo(WebAPI.GameDataAccess.FindGameFromId(gameID)));
        }
    }
}