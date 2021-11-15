using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.WeeklyTeamReport.Domain
{
    public class TeamMember
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public List<WeeklyReport> ReportList{ get; private set; }

        public TeamMember(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            ReportList = new List<WeeklyReport>();
        }


        public void AddReport(WeeklyReport report)
        {
            ReportList.Add(report);
        }
    }
}
