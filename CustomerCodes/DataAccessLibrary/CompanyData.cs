using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public class CompanyData : ICompanyData
    {
        private readonly ISqlDataAccess _db;

        public CompanyData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<Company> GetCompany(Guid CompanyId)
        {
            string sql = @"EXEC dbo.Return_Company @pCompanyId = @CompanyId";

            return _db.LoadSingle<Company, dynamic>(sql, new { CompanyId });
        }

        public Task<UserAccount> ValidateCompanyLogIn(LogInObject newLogInRequest)
        {
            string sql = @"EXEC dbo.CompanyLogIn @pLoginUsername = @Username, @pPassword = @Password";

            return _db.LoadSingle<UserAccount, dynamic>(sql, newLogInRequest);
        }

        public Task<CompanyDashStats> GetCompanyDashStats(Guid CompanyId)
        {
            string sql = @"EXEC dbo.Return_CompanyDashStats @pCompanyId = @CompanyId";

            return _db.LoadSingle<CompanyDashStats, dynamic>(sql, new { CompanyId });
        }

        public Task<List<CompanyWeekGraphStats>> GetCompanyWeekGraphStats(Guid CompanyId)
        {
            string sql = @"EXEC dbo.Return_CompanyWeeklyStats @pCompanyId = @CompanyId";

            return _db.LoadData<CompanyWeekGraphStats, dynamic>(sql, new { CompanyId });
        }

        public Task<List<CompanyDayGraphStats>> GetCompanyDayGraphStats(Guid CompanyId)
        {
            string sql = @"EXEC dbo.Return_CompanyDayStats @pCompanyId = @CompanyId";

            return _db.LoadData<CompanyDayGraphStats, dynamic>(sql, new { CompanyId });
        }

        //public Task<User> Authenticate_User(LoginRequest loginRequest)
        //{
        //    string sql = @"EXEC dbo.Authenticate_User @pGivenUsername = @Username, @pGivenPassword = @Password";

        //    return _db.LoadSingle<User, dynamic>(sql, loginRequest);
        //}

        //public Task<LoginRequest> Register_User(RegisterRequest registerRequest)
        //{
        //    string sql = @"EXEC dbo.Create_User @pUsername = @Username, @pEmail = @EmailAddress, @pPassword = @Password";

        //    return _db.SaveData<LoginRequest, dynamic>(sql, registerRequest);
        //}

    }
}
