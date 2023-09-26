using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using HotelApi.Shared.Entities;

namespace HotelApi.DataAccess.Repositories
{
    public class UserRepository
    {
        private readonly IConfiguration _config;
        public UserRepository(IConfiguration config)
        {
            _config = config;
        }

        private IDbConnection CreateConnection()
        {
            return new SqlConnection(_config.GetConnectionString("DefaultConnection"));
        }

        public bool ValidateUser(string username, string passwordHash)
        {
            using var dbConnection = CreateConnection();
            dbConnection.Open();

            string query = $"SELECT * FROM UserAccounts WHERE Username = '{username}' AND PasswordHash = '{passwordHash}'";
            
            if(dbConnection.Query(query).Count() == 1) 
            {
                return true;
            }

            return false;
        }
    }
}