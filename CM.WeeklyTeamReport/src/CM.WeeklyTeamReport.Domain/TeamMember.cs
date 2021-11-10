using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.WeeklyTeamReport.Domain
{
    public class TeamMember
    {
        public TeamMember(string FirstName, string LastName, TypeOfTeam typeOfTeam)
        {
            this.FirstName = FirstName; this.LastName = LastName; this.typeOfTeam = typeOfTeam;
            teamMemberReports = new List<WeeklyReport>();
        }
        
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public TypeOfTeam typeOfTeam{ get; private set; }
        public List<WeeklyReport> teamMemberReports { get; private set; }
        public void CreateMemberReport(WeeklyReport report)
        {
            teamMemberReports.Add(report);
        }
        public void ChangeInformation(string? FirstName, string? LastName)
        {
            if (FirstName != null)
                this.FirstName = FirstName;
            if (LastName != null)
                this.LastName = LastName;
        }
        public void DeleteReport(int idOfReport)
        {
            teamMemberReports.RemoveAt(idOfReport);
        }
    }
    public enum TypeOfTeam
    {
        Immediate, Extended
    }
}
