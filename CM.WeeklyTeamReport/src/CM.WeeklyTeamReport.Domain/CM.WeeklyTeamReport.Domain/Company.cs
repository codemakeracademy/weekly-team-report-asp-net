namespace CM.WeeklyTeamReport.Domain
{
    public class Company
    {
        public string CompanyName { get; set; }
        public List<TeamMember> _companyTeamMembers = new List<TeamMember>();
        public List<TeamMember> CompanyTeamMembers()
        {
            return _companyTeamMembers;
        }
        public Company(string companyName)
        {
            CompanyName = companyName;
        }
        public void AddTeamMember(string FirstName, string LastName)
        {
            _companyTeamMembers.Add(new TeamMember(FirstName, LastName));
        }
    }
}