using System;
using System.Collections.Generic;
using Xunit;

namespace CM.WeeklyTeamReport.Domain.Testss
{
   public  class WeeklyReportTests
    {
        [Fact]
        public void ShouldBeAbleToCreateAReport()
        {
            TeamMember member = new TeamMember("Valeria", "Berezikova", "Trainee");
            WeeklyReport report = new WeeklyReport(member, "Something happened this week");
            Assert.NotNull(report);
        }
    }
}
