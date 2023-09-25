using System;

namespace GradeBookApp
{
    class Program
    {
        // main method
        static void Main(string[] args)
        {
            List<double> compGrades = new List<double>{90.5, 85.0, 65.0}; // declare and initialise at same time and add values

            // create gradebooks:
            GradeBook mathBook = new GradeBook("Maths"); // using first consutrctor (GradeBook)
            GradeBook compBook = new GradeBook("Comp", compGrades); // using second constructor

            mathBook.AddGrade(99.0);
            mathBook.AddGrade(45.6);
            mathBook.AddGrade(67.8);

            // compBook already has grades in it above

            double mathAverage = mathBook.GetAverageGrade();
            double compAverage = compBook.GetAverageGrade();

            Console.WriteLine($"The avarage grade for maths is: {mathAverage}");
            Console.WriteLine(compBook.ToString);
        }
    }
}