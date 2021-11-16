using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CM.WeeklyTeamReport.Domain;

namespace CM.WeeklyTeamReport.DomainTest
{
    public class TeamMemberTest
    {

        [Fact]
        public void ShouldBeAbleToCreateWeeklyTeamMember()
        {
            TeamMember member = new TeamMember("John","Smith");

            Assert.Equal("John", member.FirstName);
            Assert.Equal("Smith", member.LastName);
            Assert.NotNull(member.ReportList);
            Assert.NotNull(member);
        }

        [Fact]
        public void ShouldBeAbleToAddNewWeeklyReports()
        {
            WeeklyReport report = new WeeklyReport("Week 45", new DateTime(2021, 11, 12), "Smith");
            TeamMember member = new TeamMember("John", "Smith");
            List < WeeklyReport > reports = new List<WeeklyReport>();
            member.AddReport(report);
            Assert.True(member.ReportList.Count==1);
        }
    }
}
