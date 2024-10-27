using System.IO;

namespace Stub
{
    public class FileDataObject
    {
        public string GetFileContent(string filePath)
        {
            if (File.Exists(filePath)) 
            {
                return File.ReadAllText(filePath); 
            }
            return string.Empty; 
        }
    }
}
