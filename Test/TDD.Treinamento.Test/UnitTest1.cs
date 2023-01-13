using TDD.Treinamento.API.Models;
using TDD.Treinamento.API.Models.Returns;
using TDD.Treinamento.API.Processors;
using TDD.Treinamento.API.Services.DataAccess.Data;
using Moq;

namespace TDD.Treinamento.Test
{
    public class UnitTest1
    {
        [Fact(DisplayName = "Realizar validacao do usuario")]
        public async Task Test1Async(string cpf)
        {
            //ARRANGE
            var clienteEntrada = new ClienteEntradaModel
            {
                Cpf = "123"
            };
            var mockClienteData = new Moq.Mock<IClienteData>();

            var processadoCliente = new ProcessardorCliente(mockClienteData.Object);
            //ACT
            var sut = await processadoCliente.ValidarPessaoFisica(It.IsAny<ClienteEntradaModel>());

            //ASSERTS
            //Assert.NotNull(sut);
            Assert.IsType<ValidaPessoaFisicaReturn>(sut);
            Assert.Equal(clienteEntrada.Cpf, sut.Cpf);
        }
    }
}