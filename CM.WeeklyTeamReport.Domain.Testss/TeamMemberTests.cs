using System;
using System.Collections.Generic;
using Xunit;

namespace CM.WeeklyTeamReport.Domain.Testss
{
    public class TeamMemberTests
    {
        [Fact]
        public void ShouldBeAbleToCreatePerson()
        {
            TeamMember member = new TeamMember("Valeria", "Berezikova", "trainee");
            Assert.NotNull(member);
        }
        [Fact]
        public void ShouldAddName()
        {
            TeamMember member = new TeamMember("Valeria", "Berezikova", "trainee");
            Assert.Equal("Valeria", member.FirstName);
        }
        [Fact]
        public void ShouldAddReport()
        {
            TeamMember member = new TeamMember("Valeria", "Berezikova", "trainee");
            WeeklyReport report = new WeeklyReport(member, "Something");
            member.AddReport(report);
        }
    }
}
