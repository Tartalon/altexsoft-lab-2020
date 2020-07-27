using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите путь к файлу");
            string fileName = Console.ReadLine();
            string fileText = File.ReadAllText(fileName);
            Console.WriteLine(fileText);
            Console.WriteLine("Укажите слово, символ");
            string word = Console.ReadLine();
            string changeText = fileText.Replace(word, "");
            Console.WriteLine(changeText);
            File.WriteAllText("changeText.txt", changeText);
            Console.ReadKey();

        }
    }
}
