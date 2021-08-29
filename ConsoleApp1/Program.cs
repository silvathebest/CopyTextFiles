using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dirPath = "D://works";
            //Создаем файл
            StreamWriter f = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/textFile.txt", true);
            //Указываем нужные нам расширения
            string[] ext = new string[2] { "*.cs", "*.xaml" };

            foreach (string found in ext)
            {
                string[] extracted = Directory.GetFiles(dirPath, found, SearchOption.AllDirectories);

                foreach (string file in extracted)
                {
                    //Записываем в файл строки
                    string[] lines = File.ReadAllLines(file);
                    foreach (string s in lines)
                    {
                        f.WriteLine(s);
                    };
                }
            }
            f.Close();
        }
    }
}
