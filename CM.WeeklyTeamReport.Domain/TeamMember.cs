using System;
using System.Collections.Generic;

namespace CM.WeeklyTeamReport.Domain
{
    public class TeamMember
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Title { get; private set; }
        public List<WeeklyReport> reports = new List<WeeklyReport>();
        public List<WeeklyReport> Reports { get { return reports;} }
        public TeamMember(string firstname, string lastname, string title)
        {
            FirstName = firstname;
            LastName = lastname;
            Title = title;
        }
        public void AddReport(WeeklyReport newreport)
        {
            if (newreport!=null)
            {
                reports.Add(newreport);
            }
        }
    }
}
