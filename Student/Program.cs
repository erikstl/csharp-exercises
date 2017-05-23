using System;
using System.Collections.Generic;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Student
    {
        public string name;
        public int id;
        public int credits;
        private double gpa;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Credits
        {
            get { return credits; }
            set { credits = value; }
        }

        public double Gpa
        {
            get { return gpa; }
            private set { gpa = value; }
        }
    }

    public class Course
    {
        public string courseName;
        public int courseNum;
        public Dictionary<string, string> roster = new Dictionary<string, string>();
    }
}