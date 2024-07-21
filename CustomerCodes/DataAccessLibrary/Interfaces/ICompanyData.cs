using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Interfaces
{
    public interface ICompanyData
    {
        Task<Company> GetCompany(Guid CompanyId);

        Task<UserAccount> ValidateCompanyLogIn(LogInObject newLogInRequest);

        Task<CompanyDashStats> GetCompanyDashStats(Guid CompanyId);
        
        Task<List<CompanyWeekGraphStats>> GetCompanyWeekGraphStats(Guid CompanyId);
        
        Task<List<CompanyDayGraphStats>> GetCompanyDayGraphStats(Guid CompanyId);


        //Task<User> Authenticate_User(LoginRequest loginrequest);

        //Task<LoginRequest> Register_User(RegisterRequest registerRequest);


    }
}
