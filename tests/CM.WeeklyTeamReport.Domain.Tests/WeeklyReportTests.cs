﻿using System;
using Xunit;

namespace CM.WeeklyTeamReport.Domain.Tests
{
    public class WeeklyReportTests
    {
        [Fact]
        public void ShouldCreateReport()
        {
            var author = new TeamMember("1", "1", "1", "email@example.com");
            var moraleEstimation = new WeeklyReport.Estimation(WeeklyReport.Estimation.EstLevel.VeryLow);
            var stressEstimation = new WeeklyReport.Estimation(WeeklyReport.Estimation.EstLevel.Low);
            var workloadEstimation = new WeeklyReport.Estimation(WeeklyReport.Estimation.EstLevel.Average, "Usual amount of stress");
            const string HighThisWeek = "My high this week";
            const string LowThisWeek = "My low this week";
            var reportDate = new DateTime(2021, 11, 10);
            var expectedWeekStart = new DateTime(2021, 11, 8);
            var expectedWeekEnd = new DateTime(2021, 11, 14);

            var report = new WeeklyReport(
                    author,
                    moraleEstimation,
                    stressEstimation,
                    workloadEstimation,
                    HighThisWeek,
                    LowThisWeek,
                    reportDate
                );

            Assert.Equal(author, report.Author);
            Assert.Equal(moraleEstimation, report.MoraleEstimation);
            Assert.Equal(stressEstimation, report.StressEstimation);
            Assert.Equal(workloadEstimation, report.WorkloadEstimation);
            Assert.Equal(HighThisWeek, report.HighThisWeek);
            Assert.Equal(LowThisWeek, report.LowThisWeek);
            Assert.Equal(reportDate, report.Date);
            Assert.Equal(expectedWeekStart, report.WeekStartDate);
            Assert.Equal(expectedWeekEnd, report.WeekEndDate);
        }

        [Fact]
        public void ShouldCreateEstimation()
        {
            var estimation = new WeeklyReport.Estimation(WeeklyReport.Estimation.EstLevel.VeryLow, "Very Low");

            Assert.Equal(WeeklyReport.Estimation.EstLevel.VeryLow, estimation.Level);
            Assert.Equal("Very Low", estimation.Commentary);
        }
    }
}
