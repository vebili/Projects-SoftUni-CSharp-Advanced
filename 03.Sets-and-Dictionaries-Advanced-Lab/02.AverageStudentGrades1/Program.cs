using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageStudentGrades1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> grades = new Dictionary<string, List<decimal>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                decimal grade = decimal.Parse(input[1]);
                if (!grades.ContainsKey(name))
                    grades[name] = new List<decimal>();
                grades[name].Add(grade);
            }
            foreach (var item in grades)
            {
                string name = item.Key;
                List<decimal> studentsGrades = item.Value;
                decimal average = studentsGrades.Average();
                Console.Write($"{name} -> ");
                foreach (var grade in studentsGrades)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {average:f2})");
            }
        }
    }
}