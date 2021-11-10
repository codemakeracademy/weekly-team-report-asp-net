using System;
using Xunit;

namespace CM.WeeklyTeamReport.Domain.Tests
{
    public class TeamMemberTest
    {
        [Fact]
        public void ShouldBeTeamMember()
        {
            string firstName = "John";
            string lastName = "Doe";
            var role = TeamMember.Roles.junior;
            TeamMember teamMember = new TeamMember(firstName, lastName, role);
            Assert.NotNull(teamMember);
            Assert.Equal("John", teamMember.FirstName);
            Assert.Equal("Doe", teamMember.LastName);
            Assert.Equal(TeamMember.Roles.junior, teamMember.Role);
        }
    }
}
