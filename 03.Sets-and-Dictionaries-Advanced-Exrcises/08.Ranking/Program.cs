using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contestPassword = new Dictionary<string, string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of contests")
                {
                    break;
                }
                string[] inputLine = input.Split(':');
                string contest = inputLine[0];
                string password = inputLine[1];
                if (!contestPassword.ContainsKey(contest))
                {
                    contestPassword[contest] = password;
                }
            }
            Dictionary<string, Dictionary<string, int>> studentContests = new Dictionary<string, Dictionary<string, int>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of submissions")
                {
                    break;
                }
                string[] inputLine = input.Split("=>");
                string contest = inputLine[0];
                string password = inputLine[1];
                string userName = inputLine[2];
                int points = int.Parse(inputLine[3]);

                if (contestPassword.ContainsKey(contest)
                    && contestPassword[contest] == password)
                {
                    if (!studentContests.ContainsKey(userName))
                    {
                        studentContests[userName] = new Dictionary<string, int>();
                    }
                    if (!studentContests[userName].ContainsKey(contest))
                    {
                        studentContests[userName][contest] = points;
                    }
                    if (points > studentContests[userName][contest])
                    {
                        studentContests[userName][contest] = points;
                    }
                }
            }
            var bestUser = studentContests
                                .OrderByDescending(u => u.Value.Values.Sum())
                                .First();
            Console.WriteLine($"Best candidate is {bestUser.Key} with total {bestUser.Value.Values.Sum()} points.");
            Console.WriteLine("Ranking:");
            foreach (var student in studentContests.OrderBy(s => s.Key))
            {
                Console.WriteLine(student.Key);
                foreach (var lang in student.Value
                                    .OrderByDescending(l => l.Value))
                {
                    Console.WriteLine($"#  {lang.Key} -> {lang.Value}");
                }
            }
        }
    }
}