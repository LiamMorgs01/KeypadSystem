namespace DataAccessLibrary.Models
{
    public class UserAccount
    {
        public UserAccount(string username, Guid companyId, string role)
        {
            this.UserName = username;
            this.CompanyId = companyId;
            this.Role = role;
        }

        public string UserName { get; set; }
        public Guid CompanyId { get; set; }

        public string Role {  get; set; }
    }
}
