using TDD.Treinamento.API.Models;
using TDD.Treinamento.API.Models.Returns;
using TDD.Treinamento.API.Services.DataAccess.Data;

namespace TDD.Treinamento.API.Processors
{
    public class ProcessardorCliente
    {

        private IClienteData _clienteData;

        public ProcessardorCliente(IClienteData clienteData)
        {
            _clienteData = clienteData;
        }

        public async Task<ValidaPessoaFisicaReturn> ValidarPessaoFisica(ClienteEntradaModel cliente)
        {
            var request = await _clienteData.ConsultaCliente(cliente);

            return new ValidaPessoaFisicaReturn { Cpf = cliente.Cpf };
        }
    }
}
