﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.WeeklyTeamReport.Domain
{
    public class WeeklyReport
    {
        public DayOfWeek DateStart { get; private set; }
        public double Duration { get; set; }
        public string Task { get; set; }

        public WeeklyReport(DayOfWeek dateStart, double duration, string task)
        {
            DateStart = dateStart;
            Duration = duration;
            Task = task;
        }
    }
}
