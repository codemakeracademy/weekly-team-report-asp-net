using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CM.WeeklyTeamReport.Domain.Tests
{
    public class TeamMemberTests
    {
        List<WeeklyReport> reportsList = new List<WeeklyReport>();
        [Fact]
        public void ShouldBeAbleToCreateTeamMemberObject()
        {
            TeamMember teamMember = new TeamMember("Name", "Surname", "CEO", "someUrl", "awdaw@ad.wad", reportsList, reportsList, reportsList);
            Assert.NotNull(teamMember);
            Assert.Equal("Name", teamMember.FirstName);
            Assert.Equal("Surname", teamMember.LastName);
            Assert.Equal("CEO", teamMember.Title);
            Assert.Equal("someUrl", teamMember.InviteLink);
            Assert.Equal("awdaw@ad.wad", teamMember.Mail);
            Assert.Equal(reportsList, teamMember.ReportsList);
            Assert.Equal(reportsList, teamMember.ReportsListFromMember);
            Assert.Equal(reportsList, teamMember.ReportsListToMember);
        }

        [Theory]
        [InlineData(null, "New Surname", "New title")]
        [InlineData("", "New Surname", "New title")]
        public void ShouldUpdateFirstNameCorrectly(string newName, string newSurname, string newTitle)
        {
            TeamMember teamMember = new TeamMember("Name", "Surname", "CEO", "someUrl", "awdaw@ad.wad", reportsList, reportsList, reportsList);
            string oldName = teamMember.FirstName;
            teamMember.UpdateMemberData(newName, newSurname, newTitle);
            Assert.Equal(oldName, teamMember.FirstName);
        }

        [Theory]
        [InlineData("New Name", null, "New title")]
        [InlineData("New Name", "", "New title")]
        public void ShouldUpdateLastNameCorrectly(string newName, string newSurname, string newTitle)
        {
            TeamMember teamMember = new TeamMember("Name", "Surname", "CEO", "someUrl", "awdaw@ad.wad", reportsList, reportsList, reportsList);
            string oldSurname = teamMember.LastName;
            teamMember.UpdateMemberData(newName, newSurname, newTitle);
            Assert.Equal(oldSurname, teamMember.LastName);
        }

        [Theory]
        [InlineData("New Name", "New Surname", null)]
        [InlineData("New Name", "New Surname", "")]
        public void ShouldUpdateTitleCorrectly(string newName, string newSurname, string newTitle)
        {
            TeamMember teamMember = new TeamMember("Name", "Surname", "CEO", "someUrl", "awdaw@ad.wad", reportsList, reportsList, reportsList);
            string oldTitle = teamMember.Title;
            teamMember.UpdateMemberData(newName, newSurname, newTitle);
            Assert.Equal(oldTitle, teamMember.Title);
        }
    }
}
