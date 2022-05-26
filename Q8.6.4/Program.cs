using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FinalTask
{
    class Program
    {
        const string desktop = "C://Users/Администратор/Desktop/Students";
        const string path = "C://Users/Администратор/Desktop/Students(2).dat";


        static void Main(string[] args)
        {
            if (!File.Exists(desktop))
            {
                try
                {
                   var directory = Directory.CreateDirectory(desktop);
                    Console.WriteLine(directory);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
           
            ReadValues();
        }


        static void ReadValues()
        {
            
            if (File.Exists(path))
            {
                var formatter = new BinaryFormatter();
                Student[] students;

                using (var stream = new FileStream(path, FileMode.Open))
                {
                    students = formatter.Deserialize(stream) as Student[];
                    Console.WriteLine("Из файла считано:");
                    Console.WriteLine(students[0].Group);
                }
                foreach (var St in students) 
                {
                    File.AppendAllText($"C://Users/Администратор/Desktop/Students/{St.Group}.txt", $"{St.Name},{St.DateOfBirth}\n");
                }
            }
        }


    }

    [Serializable]
    class Student
    {
        public string Name { get; set; }
        public string Group { get; set; }
        public DateTime DateOfBirth { get; set; }


    }
}
