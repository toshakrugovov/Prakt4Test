using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Stub.Tests
{
    [TestClass]
    public class FileManagerTests
    {
        [TestMethod]
        public void Kolvochifrvfile_1234567890_10()
        {
            
            FileManager fileManager = new FileManager();
            string fileName = "file1.txt"; 
            int expected = 10; 

  
            int actual = fileManager.CountDigitsInFile(fileName);

            
            Assert.AreEqual(expected, actual, $"Ожидалось {expected} цифр в файле {fileName}, но было найдено {actual}.");
        }
    }
}