﻿using TDD.Treinamento.API.Models;
using TDD.Treinamento.API.Models.Returns;

namespace TDD.Treinamento.API.Services.DataAccess.Data
{
    public interface IClienteData
    {
        Task<IEnumerable<ValidaPessoaFisicaReturn>> ConsultaCliente(ClienteEntradaModel cliente);
    }
}