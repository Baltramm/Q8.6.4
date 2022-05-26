using System;
using System.IO;

namespace Q8._6._4
{
    class Program
    {
        const string desktop = "C://Users/Администратор/Desktop/Students";
        const string path = "C://Users/Администратор/Desktop/Student.dat";


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
            WriteValues();
            ReadValues();
        }


        static void ReadValues()
        {
            string StringValue;
            if (File.Exists(path))
            {
        
                using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
                {
                    StringValue = reader.ReadString();     
                }
                Console.WriteLine("Из файла считано:");
                Console.WriteLine(StringValue);
            }
        }
        static void WriteValues()
        {
            var student1 = new Student("Олег", "ИС-101", Convert.ToDateTime("01.01.2000"));
            var student2 = new Student("Игорь", "ИС-102", Convert.ToDateTime("02.02.2001"));
            var student3 = new Student("Иван", "ИС-103", Convert.ToDateTime("03.03.2002"));
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                writer.Write($"Имя:{student1.Name},Группа:{student1.Group},Дата рождения:{student1.DateOfBirth}\n");
                writer.Write($"Имя:{student2.Name},Группа:{student2.Group},Дата рождения:{student2.DateOfBirth}\n");
                writer.Write($"Имя:{student3.Name},Группа:{student3.Group},Дата рождения:{student3.DateOfBirth}\n");
            }
        }

    }
  
    class Student
    {
        public string Name { get; set; }
        public string Group { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Student (string name, string group, DateTime dateOfBirth)
        {
            Name = name;
            Group = group;
            DateOfBirth = dateOfBirth;
        }
    }
}
