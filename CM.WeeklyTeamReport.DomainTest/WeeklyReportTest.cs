using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CM.WeeklyTeamReport.Domain;

namespace CM.WeeklyTeamReport.DomainTest
{
    public class WeeklyREportTest
    {

        [Fact]
        public void ShouldBeAbleToCreateWeeklyReport()
        {
            WeeklyReport report = new WeeklyReport("Week 45", new DateTime(2021, 11, 12), "Smith");

            Assert.Equal("Week 45", report.ReportName);
            Assert.Equal(new DateTime(2021, 11, 12), report.Date);
            Assert.Equal("Smith", report.Author);
            Assert.NotNull(report);
        }
    }
}
