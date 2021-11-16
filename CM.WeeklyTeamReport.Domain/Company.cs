using System;
using System.Collections.Generic;

namespace CM.WeeklyTeamReport.Domain
{
    public class Company
    {
    public string CompanyName { get; private set;}
    public List<TeamMember> EmployeeList { get; set; }
    
    public Company(string name)
        {
            CompanyName = name;
            EmployeeList = new List<TeamMember>();
        }

    }
}
