using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public class CustomerData : ICustomerData
    {
        private readonly ISqlDataAccess _db;

        public CustomerData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<Customer> ValidateCustomer(CustomerCode Code)
        {
            string sql = @"EXEC dbo.Validate_CustomerCode @pCustomerCode = @Code";

            return _db.LoadSingle<Customer, dynamic>(sql, Code);
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
