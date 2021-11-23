﻿using FluentAssertions;
using System;
using Xunit;

namespace CM.WeeklyTeamReport.Domain.IntegrationTests
{
    public class WeeklyReportRepositoryTests
    {
        [Fact]
        public void ShouldPerformBasicCRUD()
        {
            var company = new CompanyRepository().Create(new Company { Name = "Test company" });
            var reportingTM = new TeamMemberRepository().Create(new TeamMember
            {
                FirstName = "F",
                LastName = "L",
                Title = "T",
                Email = new System.Net.Mail.MailAddress("email@example.com"),
                CompanyId = company.ID
            });

            var weeklyReportRepo = new WeeklyReportRepository();
            var weeklyReport = weeklyReportRepo.Create(new WeeklyReport {
                AuthorId = reportingTM.ID,
                MoraleGrade = new Grade { Level = Level.High },
                StressGrade = new Grade { Level = Level.Average, Commentary = "Average stress" },
                WorkloadGrade = new Grade { Level = Level.VeryHigh },
                HighThisWeek = "I was MVP this thursday",
                LowThisWeek = "Got sick",
                Date = DateTime.Now
            });

            weeklyReport.ID.Should().NotBe(0);
            weeklyReport.MoraleGradeId.Should().NotBe(0);
            weeklyReport.StressGradeId.Should().NotBe(0);
            weeklyReport.WorkloadGradeId.Should().NotBe(0);

            var readWR = weeklyReportRepo.Read(weeklyReport.ID);
            readWR.AuthorId.Should().Be(weeklyReport.AuthorId);
            readWR.MoraleGrade.Should().BeEquivalentTo(weeklyReport.MoraleGrade);
            readWR.StressGrade.Should().BeEquivalentTo(weeklyReport.StressGrade);
            readWR.WorkloadGrade.Should().BeEquivalentTo(weeklyReport.WorkloadGrade);
            readWR.HighThisWeek.Should().Be(weeklyReport.HighThisWeek);
            readWR.LowThisWeek.Should().Be(weeklyReport.LowThisWeek);
            readWR.AnythingElse.Should().Be(weeklyReport.AnythingElse);
            readWR.Date.Should().Be(weeklyReport.Date);

            var newHigh = "No, it was tuesday";
            weeklyReport.HighThisWeek = newHigh;
            var newMoraleGrade = new Grade { Level = Level.Low, Commentary = "Actually I was dismoraled" };
            weeklyReport.MoraleGrade = newMoraleGrade;
            weeklyReportRepo.Update(weeklyReport);
            readWR = weeklyReportRepo.Read(weeklyReport.ID);
            readWR.HighThisWeek.Should().Be(newHigh);
            readWR.MoraleGrade.Level.Should().Be(newMoraleGrade.Level);
            readWR.MoraleGrade.Commentary.Should().Be(newMoraleGrade.Commentary);

            weeklyReportRepo.Delete(weeklyReport);
            readWR = weeklyReportRepo.Read(weeklyReport.ID);
            readWR.Should().BeNull();

            new TeamMemberRepository().Delete(reportingTM);
            new CompanyRepository().Delete(company);
        }
    }
}
