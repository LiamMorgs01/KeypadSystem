namespace KeypadSystem.Authentication
{
    public class UserSession
    {
        public string UserName { get; set; }

        public string Role {  get; set; }

        public Guid CompanyId { get; set; }
    }
}
