using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.WeeklyTeamReport.Domain
{
    public class TeamMember
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<WeeklyReport> Reports { get; private set; }
        public TeamMember(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Reports = new List<WeeklyReport>();
        }
        public void AddReport(WeeklyReport report)
        {
            Reports.Add(report);
        }
    }
}
