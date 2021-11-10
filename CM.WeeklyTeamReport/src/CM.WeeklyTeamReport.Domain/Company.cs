using System;
using System.Collections.Generic;

namespace CM.WeeklyTeamReport.Domain
{
    public class Company
    {
        public Company(string CompanyName, List<TeamMember> TeamMembers)
        {
            this.CompanyName = CompanyName; this.TeamMembers = TeamMembers;
        }
        public string CompanyName { get; set; }
        public List<TeamMember> TeamMembers { get; set; }
    }
}
