using System;
using System.IO;

namespace Q8._6._4
{
    class Program
    {
        const string desktop = "C://Users/Администратор/Desktop/";
        const string path = "C://Users/Администратор/Desktop/Students.dat";

        static void Main(string[] args)
        {
            if (!Directory.Exists(desktop))
            {
                try
                {
                   var directory = Directory.CreateDirectory(desktop); 
                   
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }


        static void ReadValues()
        {
            string StringValue;


            if (File.Exists(path))
            {
                // Создаем объект BinaryReader и инициализируем его возвратом метода File.Open.
                using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
                {
                    // Применяем специализированные методы Read для считывания соответствующего типа данных.
                    StringValue = reader.ReadString();
                }

                Console.WriteLine("Из файла считано:");
                Console.WriteLine(StringValue);

            }
        }
    }
}
