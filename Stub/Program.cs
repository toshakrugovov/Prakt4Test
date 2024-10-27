using System;

namespace Stub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь к файлу или название файла:");
            string filePath = Console.ReadLine();

            FileManager mgr = new FileManager();

            
            int digitCount = mgr.CountDigitsInFile(filePath);
            if (digitCount >= 0) 
            {
                Console.WriteLine($"Количество цифр в файле {filePath}: {digitCount}");
            }
            else
            {
                Console.WriteLine($"Файл {filePath} не найден!");
            }

            Console.ReadKey();
        }
    }
}
