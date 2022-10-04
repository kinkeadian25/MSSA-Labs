using System;
using System.Collections.Generic;
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
            AddClass("PCAD8", false, false, false);
        }
        static void SetInstructorName(string instructorName) 
        { 
        
        }
        static void SetCourseTitle(string courseTitle)
        {
            bool outcome = ValidateCourseTitle(courseTitle);
            if (outcome)
            {
                string title = courseTitle;
                Console.Out.WriteLine("Course title is " + title);
            }
            else
            {
                Console.WriteLine("Error: Class name is too long.");
            }
        }
        static bool ValidateCourseTitle(string correctTitle)
        {
            if (correctTitle.Length <= 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void AddClass(string courseTitle, bool isInProgram, bool isRequired, bool isElective)
        {
            if (isInProgram)
            {
                if (isRequired)
                {
                    Console.Out.WriteLine(courseTitle + " is in the program and is a required course.");
                }
                else if (isElective)
                {
                    Console.Out.WriteLine(courseTitle + " is in the program and is an elective.");
                }
                else
                {
                    Console.Out.WriteLine(courseTitle + " is in the program and is extra credit.");
                }
            }
            else
            {
                Console.Out.WriteLine(courseTitle + " is not in the Program.");
            }
        }

        static void Reminders(string dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case "Wednesday":
                    Console.WriteLine("Discussion post due today.");
                    break;
                case "Friday":
                    Console.WriteLine("Quiz today");
                    break;
                case "Sunday":
                    Console.WriteLine("Assignment Due");
                    break;
                default:
                    Console.WriteLine("Lecture day");
                    break;                  
            }
        }

        static void CalculateAverage()
        {
            double[] grades = new double[] { 89, 98, 99, 90, 95 };
            
        }
    }
}
