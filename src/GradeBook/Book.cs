using System;
using System.Collections.Generic;

namespace GradeBook
{
    internal class Book
    {
        List<double> grades;
        public Book()
        {
            grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
            
        }

        public double ComputeAverage(List<double> grades)
        {
            var result = 0.0;

            foreach (var number in grades)
            {
                result += number;
            }

            result /= grades.Count;

            Console.WriteLine($"The average grade is {result:N1}");
            
            return result;
            
        }
    }
}