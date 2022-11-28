using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.ModelLayer
{
    internal class GameFile
    {
        public GameFile()
        {

        }
        public GameFile(String fileName, byte[] fileContent)
        {

        }
        public GameFile(int gameID, String fileName, byte[] fileContent)
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
