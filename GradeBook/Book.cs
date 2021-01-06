using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        private List<double> grades;
        private string name;

        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var avgGrade = 0.00;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach (var grade in grades)
            {
                lowGrade = Math.Min(grade, lowGrade);
                highGrade = Math.Max(grade, highGrade);

                avgGrade += grade;
            }

            avgGrade /= grades.Count;

            Console.WriteLine($"The lowest grade is {lowGrade}");
            Console.WriteLine($"The highest grade is {highGrade}");
            Console.WriteLine($"The average grade is {avgGrade:N1}");
           
        }
    }
}