using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Gradebook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> students = new List<string>();
            List<double> grades = new List<double>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");
            do
            {
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    students.Add(newStudent);
                }
            }
            while (newStudent != "");

            // Get student grades
            foreach (string student in students)
            {
                Console.Write("Grade for " + student + ": ");
                double newGrade = double.Parse(Console.ReadLine());
                grades.Add(newGrade);
            }

            // Print class roster
            StringBuilder roster = new StringBuilder("");
            roster.Append("\nClass roster:\n");
            for (int i = 0; i < students.Count; i++)
            {
                roster.Append(students[i] + " (" + grades[i] + ")\n");
            }
            

            double sum = grades.Sum();
            double avg = sum / grades.Count;
            //string avgstring = avg.ToString();
            roster.Append("Average grade: " + avg);
            Console.WriteLine(roster);
            //Console.WriteLine("Average grade: " + avg);
            Console.ReadLine();
        }
    }
}
