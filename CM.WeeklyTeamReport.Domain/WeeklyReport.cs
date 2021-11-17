using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.WeeklyTeamReport.Domain
{
    public class WeeklyReport
    {
        public TeamMember Author { get; private set; }
        public string Content { get; set; }
        public WeeklyReport(TeamMember author, string content)
        {
            Author = author;
            Content = content;
        }
    }
}
