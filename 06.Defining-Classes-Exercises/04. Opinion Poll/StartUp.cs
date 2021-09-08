using System;

namespace OpinionPoll
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int familyMembers = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < familyMembers; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);

                Person currentMember = new Person(name, age);

                family.AddMember(currentMember);
            }

            var newFamily = family.GetPollMembers();

            foreach (var person in newFamily)
            {
                Console.WriteLine(person.ToString());
            }
           
        }
    }
}
