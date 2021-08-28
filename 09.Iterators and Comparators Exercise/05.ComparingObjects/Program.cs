using System;
using System.Collections.Generic;

namespace _05.ComparingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "END")
                {
                    break;
                }

                string name = input[0];
                int age = int.Parse(input[1]);
                string town = input[2];

                Person person = new Person(name, age, town);
                people.Add(person);
            }

            int n = int.Parse(Console.ReadLine());

            int countOfMatces = 1;

            Person targetPerson = people[n-1];

            foreach (var person in people)
            {
                if (person == targetPerson)
                {
                    continue;
                }

                if (person.CompareTo(targetPerson) == 0)
                {
                    countOfMatces++;
                }
            }

            if (countOfMatces == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{countOfMatces} {people.Count - countOfMatces} {people.Count}");
            }
        }
    }
}