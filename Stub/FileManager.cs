using System;
using System.Linq;

namespace Stub
{
    public class FileManager
    {
        public int CountDigitsInFile(string filePath)
        {
            //FileDataObject obj = new FileDataObject();
            TestDataObject obj = new TestDataObject();
            string content = obj.GetFileContent(filePath); 

           
            if (string.IsNullOrEmpty(content))
            {
                return -1; 
            }

            return content.Count(char.IsDigit); 
        }
    }
}
