using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericVariables_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Int
            int courseID;
            int lengthInWeeks; 
            #endregion
            double myGPA;
            #region Strings
            string courseTitle;
            string courseDescription;
            string instructorName;
            #endregion
            #region BooleanVar
            bool doesExist;
            bool passingGrade;
            bool isEnrolled;
            #endregion

            #region DeclaredVariables
            courseID = 101;
            lengthInWeeks = 17;
            myGPA = 3.4;
            courseTitle = "PCAD8";
            courseDescription = "Extensive training in Transact-SQL/Data and Access | Programming in C# | Programming in HTML5 with JavaScript & CSS3 | Azure Fundamentals | Azure Development | ASP.NET Core MVC application development.";
            instructorName = "Brian Nielsen";
            doesExist = true;
            passingGrade = true;
            isEnrolled = true; 
            #endregion

            if (doesExist)
            {
                Console.WriteLine(courseTitle);
                Console.WriteLine(courseDescription);
                Console.WriteLine(instructorName);
                Console.WriteLine(doesExist);
                Console.WriteLine(passingGrade);
                Console.WriteLine(isEnrolled);
                Console.WriteLine(courseID);
                Console.WriteLine(lengthInWeeks);
                Console.WriteLine(myGPA);
                Console.ReadKey(); 
            }
        }
    }
}
