using System;
using System.Collections.Generic;
using System.Linq;

namespace GradebookDict
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<double, string> students = new Dictionary<double, string>();
            string newID;

            Console.WriteLine("Enter your ID Numbers (or ENTER to finish):");
            do
            {
                Console.Write("ID: ");
                newID = Console.ReadLine();
                if (newID != "")
                {
                    // Get the student's grade
                    double newIDnumber = double.Parse(newID);
                    Console.Write("student: ");
                    string newStudent = Console.ReadLine();

                    students.Add(newIDnumber, newStudent);
                }
            }
            while (newID != "");

            // Print class roster
            Console.WriteLine("\nClass roster:");
            Console.WriteLine("ID Number (Name)");
            foreach (KeyValuePair<double, string> student in students)
            {
                Console.WriteLine(student.Key + " (" + student.Value + ")");
            }

            Console.ReadLine();
        }
    }
}
