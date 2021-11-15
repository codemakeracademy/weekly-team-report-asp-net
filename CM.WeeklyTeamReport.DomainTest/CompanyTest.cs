using System;
using Xunit;
using CM.WeeklyTeamReport.Domain;

namespace CM.WeeklyTeamReport.DomainTest
{
    public class CompanyTest
    {
        [Fact]
        public void ShouldBeAbleToCreateCompany()
        {
                Company company = new Company("AnyCompanyName");

                Assert.Equal("AnyCompanyName", company.CompanyName);
                Assert.NotNull(company.EmployeeList);
                Assert.NotNull(company);
            
        }
    }
}
