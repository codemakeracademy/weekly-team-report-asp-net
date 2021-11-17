using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.WeeklyTeamReport.Domain
{
    public class Company
    {
        public string Name { get; private set; }
        public List<TeamMember> members = new List<TeamMember>();
        public List<TeamMember> Members { get { return members; }  }
        public Company(string name)
        {
            Name = name;
        }
        public void AddMember(TeamMember newmember)
        {
            if (newmember!=null)
            {
                Members.Add(newmember);
            }

        }
    }
}
