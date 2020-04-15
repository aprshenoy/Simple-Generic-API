using Dapper;
using DapperCoreTest.Repositories.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class RepositoryTemplate<T> : IRepository<T> where T: class
    {
        private readonly IConfiguration _config;

        public RepositoryTemplate(IConfiguration config)
        {
            _config = config;
        }

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("SystemMemberConnectionString"));
            }
        }

        //public async Task<T> GetByID(int id)
        //{
        //    using (IDbConnection conn = Connection)
        //    {
        //        string sQuery = "SELECT ID, FirstName, LastName, DateOfBirth FROM Employee WHERE ID = @ID";
        //        conn.Open();
        //        var result = await conn.QueryAsync<Employee>(sQuery, new { ID = id });
        //        return result.FirstOrDefault();
        //    }
        //}

        public Task<T> get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> getAll()
        {
            throw new NotImplementedException();
        }

        public Task<int> insert(T value)
        {
            throw new NotImplementedException();
        }

        public Task<int> update(T value)
        {
            throw new NotImplementedException();
        }

        public Task<int> delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
