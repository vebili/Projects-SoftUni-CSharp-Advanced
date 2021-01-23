using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TheV_Logger1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, HashSet<string>>> nameFollowNames = new Dictionary<string, Dictionary<string, HashSet<string>>>();
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "Statistics")
                {
                    break;
                }
                if (input.Contains("joined"))
                {
                    string vlogger = input[0];
                    if (!nameFollowNames.ContainsKey(vlogger))
                    {
                        nameFollowNames[vlogger] = new Dictionary<string, HashSet<string>>();
                        nameFollowNames[vlogger]["follow"] = new HashSet<string>();
                        nameFollowNames[vlogger]["isFollowed"] = new HashSet<string>();
                    }
                }
                else if (input.Contains("followed"))
                {
                    string vlogger1 = input[0];
                    string vlogger2 = input[2];

                    if (vlogger1 == vlogger2
                        || !nameFollowNames.ContainsKey(vlogger1)
                        || !nameFollowNames.ContainsKey(vlogger2))
                    {
                        continue;
                    }
                    nameFollowNames[vlogger1]["follow"].Add(vlogger2);
                    nameFollowNames[vlogger2]["isFollowed"].Add(vlogger1);
                }
            }
            var sortedVloggers = nameFollowNames
                .OrderByDescending(v => v.Value["isFollowed"].Count)
                .ThenBy(v => v.Value["follow"].Count)
                .ToDictionary(k => k.Key, y => y.Value);
            var bestVlogger = sortedVloggers.FirstOrDefault();
            Console.WriteLine($"The V-Logger has a total of {sortedVloggers.Keys.Count} vloggers in its logs.");
            int count = 1;
            Console.WriteLine($"{count}. {bestVlogger.Key} : {bestVlogger.Value["isFollowed"].Count} followers, {bestVlogger.Value["follow"].Count} following");
            if (bestVlogger.Value["isFollowed"].Count > 0)
            {
                foreach (var followers in bestVlogger.Value["isFollowed"].OrderBy(f => f))
                {
                    Console.WriteLine($"*  {followers}");
                }
            }
            foreach (var vlogger in sortedVloggers.Skip(1))
            {
                int followersCount = vlogger.Value["isFollowed"].Count;
                int followingsCount = vlogger.Value["follow"].Count;
                Console.WriteLine($"{++count}. {vlogger.Key} : {followersCount} followers, {followingsCount} following");
            }
        }
    }
}