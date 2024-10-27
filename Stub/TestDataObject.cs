using System.Collections.Generic;

namespace Stub
{
    public class TestDataObject
    {
       
        public List<string> GetFiles()
        {
           
            return new List<string>
            {
                "file1.txt",
                "file2.txt",
                "file3.txt"
            };
        }

       
        public string GetFileContent(string fileName)
        {
           
            if (fileName == "file1.txt")
            {
                return "Это тестовый файл с цифрами: 1234567890";
            }
            if (fileName == "file2.txt")
            {
                return "Другой файл без цифр.";
            }
            if (fileName == "file3.txt")
            {
                return "Файл с некоторыми цифрами: 42 и 73.";
            }
            return null; 
        }
    }
}
