using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace GradeBookApp
{
    public class GradeBook
    {
        private string _name; // common practive to denote private var with _ in front
        private List<double> grade;

        public GradeBook(string name) // constructor
        {
            _name = name;
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

        }
    }
}