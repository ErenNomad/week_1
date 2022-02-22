using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, surname;
            int studentNum;
            Console.Write("Enter your name?: ");
            name = Console.ReadLine();
            Console.Write("Enter your surname?: ");
            surname = Console.ReadLine();
            Console.Write("Enter your student number?:");
            studentNum = Convert.ToInt32(Console.ReadLine());
            int lastStep;
            lastStep = studentNum % 10;

            Console.Write("Enter your age dd.month.year format -->");
            DateTime date = Convert.ToDateTime(Console.ReadLine());
            DateTime now = DateTime.Now;
            TimeSpan span = now.Subtract(date);
            double span2 = span.TotalDays / 365;
            int age = Convert.ToInt32(span2);

            int howLesson;
            Console.Write("How many courses will you take? (You have to choose at least 9 courses!!):");
            howLesson = Convert.ToInt32(Console.ReadLine());
            while (howLesson < 9)
            {
                Console.Write("How many courses will you take? (You have to choose at least 9 courses!!):");
                howLesson = Convert.ToInt32(Console.ReadLine());
            }

            string[] lessons = new string[howLesson];
            double[] avarage = new double[howLesson];
            int[] midtermNote = new int[howLesson];
            int[] finalNot = new int[howLesson];
            double midtermPercent = 0;
            double finalPercent = 0;

            for (int i = 0; i < howLesson; i++)
            {
                Console.Write("Enter course name:");
                lessons[i] = Console.ReadLine();
            }
            for (int i = 0; i < howLesson; i++)
            {
                Console.Write($"Enter the midterm grade of the {lessons[i]} course :");
                midtermNote[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Enter the final grade of the {lessons[i]} course  :");
                finalNot[i] = Convert.ToInt32(Console.ReadLine());
            }
            if (name.Length> surname.Length)
            {
                midtermPercent = 0.3;
            }
            else if (surname.Length> name.Length)
            {
                midtermPercent = 0.6;
            }
            else if (surname.Length == name.Length && lastStep % 2 ==1)
            {
                midtermPercent = 0.35;  
            }
            else if (surname.Length == name.Length && lastStep % 2 ==0)
            {
                midtermPercent = 0.25;
            }
            finalPercent = 1 - midtermPercent;
            for (int i = 0; i < howLesson; i++)
            {
                avarage [i] = midtermNote[i]* midtermPercent + finalNot[i]*finalPercent;
            }
            Console.WriteLine($"Dear {name} you are {age} years old..");
            for (int i = 0; i < howLesson; i++)
            {
                Console.WriteLine($"Course name : {lessons[i]}   Midterm Note : {midtermNote[i]}   Final Note : {finalNot[i]}   Avarage Note : {avarage[i]}");
            }

            Console.ReadLine();  
            Console.ReadKey();

        }  
    }
}
