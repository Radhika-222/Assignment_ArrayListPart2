using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_ArrayListPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList initialization and population
            ArrayList studentGrades = new ArrayList { 85, 92, 78, 95, 88 };

            //display and sum
            Console.WriteLine("Display Student Grades and  calculating sum");
            for (int i = 0; i < studentGrades.Count; i++)
            {
                Console.WriteLine(studentGrades[i]);
            }
            int sum = 0;
            foreach(int grade in studentGrades)
            {
                sum += grade;
            }
            Console.WriteLine("sum of grades \n" + sum);

            //Grade addition
            Console.WriteLine("Enter grade  to add studentGrades");
            string sGrade = Console.ReadLine();
            studentGrades.Add(90);
            Console.WriteLine("StudentGrades after adding new grade ");
            for (int i = 0; i < studentGrades.Count; i++)
            {
                Console.WriteLine(studentGrades[i]);
            }

            //Grade removal
            Console.WriteLine("Enter grade to remove in studentGrades");
            string rGrade = Console.ReadLine();
        
                studentGrades.Remove(78);
               Console.WriteLine("studentGrades after removing {rGrade} as follows"); ;
            for (int i = 0; i < studentGrades.Count; i++)
            {
                Console.WriteLine(studentGrades[i]);
            }

            //Search and update
            int index = studentGrades.IndexOf(95);
            if (index != -1)
            {
                studentGrades[index] = 96;

                Console.WriteLine("updating studentGrade to 96 at indexOf 95"); ;
                for (int i = 0; i < studentGrades.Count; i++)
                {
                    Console.WriteLine(studentGrades[i]);
                }
            }
            else
            {
                Console.WriteLine("grade 95 is not found");

            }
            Console.ReadKey();


        }
    }



}
     
