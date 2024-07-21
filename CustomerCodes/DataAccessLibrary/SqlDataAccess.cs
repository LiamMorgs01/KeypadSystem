using Dapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using DataAccessLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _configuration;
        public string ConnectionStringName { get; set; } = "DefaultConnection";

        public SqlDataAccess(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<List<T>> LoadData<T, U>(string SQL, U Parameters)
        {
            string connectionString = _configuration.GetConnectionString(ConnectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var Data = await connection.QueryAsync<T>(SQL, Parameters);

                return Data.ToList();
            }
        }

        public async Task<T> LoadSingle<T, U>(string SQL, U Parameters)
        {
            string connectionString = _configuration.GetConnectionString(ConnectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var Data = await connection.QueryAsync<T>(SQL, Parameters);

                return Data.FirstOrDefault();
            }
        }

        public async Task<T> SaveData<T, U>(string sql, U parameters)
        {
            string connectionString = _configuration.GetConnectionString(ConnectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var Data = await connection.QueryAsync<T>(sql, parameters);

                return Data.FirstOrDefault();
            }
        }
    }
}