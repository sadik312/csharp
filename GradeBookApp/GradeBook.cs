using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace GradeBookApp
{
    public class GradeBook
    {
        // public string Name { get; set; } // auto implemented properties - C# will handle this automatically
        private string _name; // common practive to denote private var with _ in front
        private List<double> grades;

        // overloading - there are 2 same construtors but take in different parameters
        public GradeBook(string name) // constructor
        {
            // using auto implemented prop you have to state:
            // Name = name;
            _name = name;
            grades = new List<Double>(); // initialises `grades` object
        }

        public GradeBook(string name, List<double> grades)
        {
            _name = name;
            this.grades = grades;
        }

        public string Name
        {
            // getter
            get { return _name; }
            // setter
            set { _name = value; }
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public double GetAverageGrade()
        {
            double sum = 0.0;
            foreach(double grade in grades)
            {
                sum += grade;
            }
            return grades.Count > 0 ? sum / grades.Count : 0.0 ; // returns avg 

        }

        // static method will do the same thing no matter what object calls it
        public static void ShowStaticInfo()
        {
            System.Console.WriteLine("This is a Gradebook");
        }

        public override string ToString()
        {
            return $"Gradebook Name: {_name}, Average Grade: {GetAverageGrade()}";
        }
    }
}