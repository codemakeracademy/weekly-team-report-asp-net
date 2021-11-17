using System;
using System.Collections.Generic;
using Xunit;
using CM.WeeklyTeamReport.Domain;

namespace CM.WeeklyTeamReport.Domain.Testss
{
    public class CompanyTests
    {
        [Fact]
        public void ShouldBeAbleToCreateACompany()
        {
        
            Company company = new Company("ANKOCorp");
            Assert.NotNull(company);
        }
        [Fact]
        public void ShouldBeAbleName()
        {
            Company company = new Company("ANKOCorp");
        Assert.Equal("ANKOCorp", company.Name);
        }
        [Fact]
        public void ShouldBeMemberAddition()
        {
            Company company = new Company("ANKOCorp");
            TeamMember member = new TeamMember("Anatoliy", "Kolodkin", "Director");
            company.AddMember(member);
            Assert.NotNull(company.Members);
        }

    }
}
