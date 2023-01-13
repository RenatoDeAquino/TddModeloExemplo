using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace TDD.Treinamento.API.Services.DataAccess.SqlAccess
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _configuration;

        public SqlDataAccess(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IEnumerable<T>> LoadData<T, U>(string data, U parameters, string connectionId = "Default")
        {
            using IDbConnection connection = new SqlConnection(_configuration.GetConnectionString(connectionId));
            return await connection.QueryAsync<T>(data, parameters, commandTimeout: 30);
        }
    }
}
