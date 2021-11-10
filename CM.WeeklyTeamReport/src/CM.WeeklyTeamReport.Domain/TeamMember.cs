using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.WeeklyTeamReport.Domain
{
    public class TeamMember
    {
        public enum Roles
        {
            junior,
            middle,
            leader,
            manager
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Roles Role { get; set; }

        public TeamMember(string firstName, string lastName, Roles role)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
        }
    }
}
