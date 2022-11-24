using System.Xml.Linq;

namespace WebApi.ModelLayer
{
    public class GameFile
    {
        public GameFile()
        {
                
        }
        public GameFile(String fileName, byte[]fileContent)
        {
            FileName = fileName;
            FileContent = fileContent;
        }
        #region Properties
        public String FileName { get; set; }
        public byte[] FileContent { get; set; }
        #endregion
    }
}
