using System.Xml.Linq;

namespace WebApi.ModelLayer
{
    public class Game
    {
        public Game()
        {

        }
        public Game(int gameId, int developerID, string title, string description, int yearOfRelease, string specifications, string type, float price, byte[] gameFile)
        {
            GameID = gameId;
            DeveloperID = developerID;
            Title = title;
            Description = description;
            YearOfRelease = yearOfRelease;
            Specifications = specifications;
            Type = type;
            Price = price;
            GameFile = gameFile;
        }
        public Game(int developerID, string title, string description, int yearOfRelease, string specifications, string type, float price, byte[] gameFile)
        {
            DeveloperID = developerID;
            Title = title;
            Description = description;
            YearOfRelease = yearOfRelease;
            Specifications = specifications;
            Type = type;
            Price = price;
            GameFile = gameFile;
        }
        #region Properties
        public int GameID { get; set; }
        public int DeveloperID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int YearOfRelease { get; set; }
        public string Specifications { get; set; }
        public string Type { get; set; }
        public float Price { get; set; }
        public byte[] GameFile { get; set; }
        #endregion

    }
}
