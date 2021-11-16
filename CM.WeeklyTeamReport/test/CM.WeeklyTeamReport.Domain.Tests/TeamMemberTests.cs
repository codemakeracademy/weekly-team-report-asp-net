using Xunit;

namespace CM.WeeklyTeamReport.Domain.Tests
{
    public class TeamMemberTests
    {
        [Fact]
        public void ShouldBeAbleToCreateTeamMember()
        {
            var teamMember = new TeamMember("Klim", "Basargin");
            Assert.NotNull(teamMember);
        }
        [Fact]
        public void SetAndGetMemberFirstName()
        {
            TeamMember member = new TeamMember("Klim", "Basargin");
            member.FirstName = "Ivan";
            Assert.Equal("Ivan", member.FirstName);
        }
        [Fact]
        public void SetAndGetMemberLastName()
        {
            TeamMember member = new TeamMember("Klim", "Basargin");
            member.LastName = "Ivanov";
            Assert.Equal("Ivanov", member.LastName);
        }
        [Fact]
        public void AddReport()
        {
            TeamMember member = new TeamMember("Klim", "Basargin");
            member.AddReport(new WeeklyReport("Zoo", new TeamMember("Klim", "Basargin"),"good"));
            var reports = member.Reports;
            Assert.NotNull(reports);
        }
    }
}
