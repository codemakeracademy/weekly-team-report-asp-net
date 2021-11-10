using System;

namespace CM.WeeklyTeamReport.Domain
{
    public class Company
    {
        public string CompanyName { get; set; }
        public string Country { get; set; }
        public string City { get; }
        private string _president;
        public string President { 
            get 
            {
                return _president;
            } 
        }

        public Company(string companyName, string country, string city, string president)
        {
            CompanyName = companyName;
            Country = country;
            City = city;
            _president = president;
        }
        public void NewPresident(string newPresident)
        {
            _president = newPresident;
        }
    }
}
