﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.WeeklyTeamReport.Domain
{
    public class WeeklyReport
    {
        public WeeklyReport(Condition morale, string moraleMsg, Condition stress, string stressMsg,
            Condition workload, string workloadMsg, string YourHigh, string YourLow, string AnythingElse,
            DateTime dateTime)
        {
            this.Morale = morale; this.stress = stress; this.workload = workload; this.dateTime = dateTime;
            this.moraleMsg = moraleMsg; this.stressMsg = stressMsg; this.workloadMsg = workloadMsg;
            this.YourHigh = YourHigh; this.YourLow = YourLow; this.AnythingElse = AnythingElse;
        }
        public Condition Morale { get; private set; }
        public Condition stress { get; private set; }
        public Condition workload { get; private set; }
        public DateTime dateTime { get; private set; }
        public string moraleMsg { get; private set; }
        public string stressMsg { get; private set; }
        public string workloadMsg { get; private set; }
        public string YourHigh { get; private set; }
        public string YourLow { get; private set; }
        public string AnythingElse { get; private set; }
    }
    public enum Condition
    {
        VeryLow, Low, Okay, Good, Great
    }
}

