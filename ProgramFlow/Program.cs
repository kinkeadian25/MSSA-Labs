using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            SetInstructorName("Ian Kinkead");
            SetCourseTitle("PCAD8");
            CheckClass("PCAD8", true, true, false);
            DailyReminders("Sunday");
            CalculateAverage();
            CalculateAverageWhile();
        }

        static void SetInstructorName(string name)
        {

        }
        static void SetCourseTitle(string courseTitle)
        {
            if (ValidateCourseTitle(courseTitle))
            {
                Console.WriteLine("Course Title exceeds 20 characters.");
            }
            else
            { 
                Console.WriteLine("Course Title is {0}.", courseTitle);
            }
        }
        static bool ValidateCourseTitle(string courseTitle)
        {
            if (courseTitle.Length >= 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void CheckClass(string courseTitle, bool inProgram, bool isRequired, bool isElective)
        {
            if (inProgram)
            {
                if (isRequired)
                {
                    Console.WriteLine("Class is in program and required.");
                }
                else if (isElective)
                {
                    Console.WriteLine("Class is in program and an elective.");
                }
                else
                {
                    Console.WriteLine("Class is in program but not an elective or required");
                }
            }
            else
            {
                Console.WriteLine("Class is not in program.");
            }
        }
        static void DailyReminders(string dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case "Wednesday":
                    Console.WriteLine("Discussion post due!");
                    break;
                case "Friday":
                    Console.WriteLine("Quiz Day.");
                    break;
                case "Sunday":
                    Console.WriteLine("Assignments Due");
                    break;
                default:
                    Console.WriteLine("Lecture day");
                    break;
            }
        }

        static void CalculateAverage()
        {
            double[] grades = new double[] { 89, 98, 99, 90, 95 };
            double average = 0;
            double total = 0;
            int gradeCounter;

            for (gradeCounter = 0; gradeCounter < grades.Length; gradeCounter++)
            {
                total = total + grades[gradeCounter];
            }
            average = total / grades.Length;
            Console.WriteLine("Average grade is {0}.", average);
        }
        static void CalculateAverageWhile()
        {
            double grade;
            double sumOfGrades = 0;
            double average = 0;
            double gradeCounter = 0;

            Console.WriteLine("Please enter grades, once complete enter 0 for average.");
            grade = Double.Parse(Console.ReadLine());

            while (grade != 0)
            {
                sumOfGrades = sumOfGrades + grade;
                gradeCounter++;
                grade = Double.Parse(Console.ReadLine());
            }
            average = sumOfGrades / gradeCounter;
            Console.WriteLine("Your average is {0}.", average);
        }
    }
}
