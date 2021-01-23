using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> nameFollowers = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> nameFollowing = new Dictionary<string, List<string>>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "Statistics")
                {
                    break;
                }
                if (input.Contains("joined"))
                {
                    string name = input[0];
                    if (!nameFollowers.ContainsKey(name))
                    {
                        nameFollowers[name] = new List<string>();
                        nameFollowing[name] = new List<string>();
                    }
                }
                else
                {
                    string follower = input[0];
                    string followed = input[2];

                    if (follower != followed)
                    {
                        if (nameFollowing.ContainsKey(follower)
                            && nameFollowers.ContainsKey(followed)
                            && !nameFollowing[follower].Contains(followed)
                            && !nameFollowers[followed].Contains(follower))
                        {
                            nameFollowing[follower].Add(followed);
                            nameFollowers[followed].Add(follower);
                        }
                    }
                }
            }
            Console.WriteLine($"The V-Logger has a total of {nameFollowers.Keys.Count} vloggers in its logs.");
            var sortedVloggers = nameFollowers
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => nameFollowing[x.Key].Count);
            var bestVlogger = sortedVloggers.FirstOrDefault();
            int count = 1;
            Console.WriteLine($"{count}. {bestVlogger.Key} : {bestVlogger.Value.Count} followers, {nameFollowing[bestVlogger.Key].Count} following");
            if (bestVlogger.Value.Count > 0)
            {
                foreach (var followers in bestVlogger.Value.OrderBy(f => f))
                {
                    Console.WriteLine($"*  {followers}");
                }
            }
            foreach (var vlogger in sortedVloggers.Skip(1))
            {
                Console.WriteLine($"{++count}. {vlogger.Key} : {vlogger.Value.Count} followers, {nameFollowing[vlogger.Key].Count} following");
            }
        }
    }
}