using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FinalTask // Объявление пространства имен для данного кода
{
    [Serializable]class Student
    {
        public string Name { get; set; }
        public string Group { get; set; }
        public DateTime Age { get; set; }
        public Student(string name, string group, DateTime age)
        {
            Name = name;
            Group = group;
            Age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            const string DataBase = "C:\\Users\\B1S3\\Desktop\\testFolder12\\Students.dat";
            Directory.CreateDirectory("C:\\Users\\B1S3\\Desktop\\Student");
            BinaryFormatter formatter = new BinaryFormatter();
            using (var fs = new FileStream(DataBase, FileMode.OpenOrCreate))
            {
                var newStudent = (Student)formatter.Deserialize(fs);
                Console.WriteLine("Объект десериализован");
                Console.WriteLine($"Имя: {newStudent.Name} Группа: {newStudent.Group} --- Возраст: {newStudent.Age}");
            }
            Console.ReadLine();
        }
    }
}
            