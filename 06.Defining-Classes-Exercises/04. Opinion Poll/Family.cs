using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpinionPoll
{
    public class Family
    {
        private List<Person> family;

        public Family()
        {
            this.family = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.family.Add(member);
        }

        public Person GetOldestMember()
        {
            return family.OrderByDescending(p => p.Age).FirstOrDefault();
        }

        public List<Person> GetPollMembers()
        {
            List<Person> pollMembers = this.family.Where(f => f.Age > 30).OrderBy(f => f.Name).ToList();

            return pollMembers;
        }
    }
}
