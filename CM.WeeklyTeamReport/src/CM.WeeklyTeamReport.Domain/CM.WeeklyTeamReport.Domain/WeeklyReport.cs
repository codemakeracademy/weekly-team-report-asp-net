using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.WeeklyTeamReport.Domain
{
    public class WeeklyReport
    {
        public string ReportName { get; set; }
        public TeamMember Author { get; set; }
        public string Text { get; set; }
        public WeeklyReport(string reportName, TeamMember author, string text)
        {
            ReportName = reportName;
            Author = author;
            Text = text;
        }
    }
}
