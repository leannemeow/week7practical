using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentListProject1
{
    public class Student
    {
        private int id;
        private string name;
        private int age;
        private static int studentCount = 0;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Id
        {
            get { return id; }
            private set { id = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public static int StudentCount
        {
            get { return studentCount; }
        }
        public Student()
        {
            this.name = "John Doe";
            this.age = 16;
            this.id = studentCount++;
        }
        public Student(string StuName, int StuAge)
        {
            this.name = StuName;
            this.age = StuAge;
            this.id = studentCount++;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Student ID: {Id}");
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine($"Student Age: {Age}");
            Console.WriteLine();
        }
    }
}
