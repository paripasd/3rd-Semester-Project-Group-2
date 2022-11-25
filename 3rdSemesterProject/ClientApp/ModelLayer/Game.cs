namespace ClientApp.ModelLayer
{
    public class Game
    {
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
