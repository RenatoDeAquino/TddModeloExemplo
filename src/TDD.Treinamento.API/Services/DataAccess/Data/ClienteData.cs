using TDD.Treinamento.API.Models;
using TDD.Treinamento.API.Models.Returns;
using TDD.Treinamento.API.Services.DataAccess.SqlAccess;

namespace TDD.Treinamento.API.Services.DataAccess.Data
{
    public class ClienteData : IClienteData
    {
        private readonly ISqlDataAccess _sql;

        public ClienteData(ISqlDataAccess sql)
        {
            _sql = sql;
        }

        public async Task<IEnumerable<ValidaPessoaFisicaReturn>> ConsultaCliente(ClienteEntradaModel cliente)
        {
            var sql = $"SELECT * CLIENTE WHERE Cpf = {cliente.Cpf}";
            var request = await _sql.LoadData<ValidaPessoaFisicaReturn, dynamic>(sql, cliente);
            return request;
        }
    }
}
