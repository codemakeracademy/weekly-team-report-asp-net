using Xunit;
using System.Linq;
using System.Collections.Generic;

namespace CM.WeeklyTeamReport.Domain.Tests
{
    public class CompanyTests
    {
        [Fact]
        public void ShouldBeAbleToCreateCompany()
        {
            var company = new Company("CodeMakers");
            Assert.NotNull(company);
        }
        [Fact]
        public void SetAndGetNameOfCompany()
        {
            Company company = new Company("CodeMakers");
            company.CompanyName = "CodeMakersNew";
            Assert.Equal("CodeMakersNew", company.CompanyName);
        }
        [Fact]
        public void SetAndGetMembersOfCompany()
        {
            Company company = new Company("CodeMakers");
            company.AddTeamMember("Klim", "Basargin");
            var companyMembers = company.CompanyTeamMembers();
            Assert.Equal("Klim", companyMembers.First().FirstName);
        }

    }
}