using System.Xml.Linq;

namespace WebApi.ModelLayer
{
    public class GameFile
    {
        public GameFile()
        {
                
        }
        public GameFile(String fileName, byte[] fileContent)
        {

        }
        public GameFile(int gameID ,String fileName, byte[]fileContent)
        {
            GameID = gameID;
            FileName = fileName;
            FileContent = fileContent;
        }
        #region Properties
        public int GameID { get; set; }
        public String FileName { get; set; }
        public byte[] FileContent { get; set; }
        #endregion
    }
}
