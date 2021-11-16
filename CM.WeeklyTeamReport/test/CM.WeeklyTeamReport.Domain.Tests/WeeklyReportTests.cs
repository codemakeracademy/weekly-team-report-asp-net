using Xunit;

namespace CM.WeeklyTeamReport.Domain.Tests
{
    public class WeeklyReportTests
    {
        [Fact]
        public void ShouldBeAbleToCreateWeeklyReport()
        {
            var weeklyReport = new WeeklyReport("CustomerLibrary", new TeamMember("Klim", "Basargin"),
                "good");
            Assert.NotNull(weeklyReport);
        }
        [Fact]
        public void SetAndGetWeeklyReportName()
        {
            WeeklyReport weeklyReport = new WeeklyReport("CustomerLibrary", new TeamMember("Klim", "Basargin"),
                "good");
            weeklyReport.ReportName = "ZooProject";
            Assert.Equal("ZooProject", weeklyReport.ReportName);
            Assert.NotNull(weeklyReport.Author);
            Assert.NotNull(weeklyReport.Text);
        }
    }
}
