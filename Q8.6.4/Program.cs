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
            
            var student1 = new Student();
            student1.Name = "Олег";
            student1.Group = "ИС-101";
            student1.DateOfBirth = Convert.ToDateTime("01.01.2000");
            var student2 = new Student();
            student2.Name = "Игорь";
            student2.Group = "ИС-102";
            student2.DateOfBirth = Convert.ToDateTime("02.02.2001");
            var student3 = new Student();
            student3.Name = "Иван";
            student3.Group = "ИС-103";
            student3.DateOfBirth = Convert.ToDateTime("03.03.2002");
            
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
     
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
              
               
                writer.Write($"");
            }
        }

    }
    class Student
    {
        public string Name { get; set; }
        public string Group { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
