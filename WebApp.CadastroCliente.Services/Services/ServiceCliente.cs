using System;
using System.Collections.Generic;
using System.Text;
using WebApp.CadastroCliente.Data.Repositorio.Interfaces;
using WebApp.CadastroCliente.Dominio.Models;
using WebApp.CadastroCliente.Services.Interfaces;
using WebApp.CadastroCliente.Services.Services.Base;

namespace WebApp.CadastroCliente.Services.Services
{
    public class ServiceCliente:ServiceBase<Cliente>, IServiceCliente
    {
        public readonly IRepositoryCliente _repositoryCliente;

        public ServiceCliente(IRepositoryCliente repositoryCliente):base(repositoryCliente)
        {
            _repositoryCliente = repositoryCliente;
        }
    }
}
