using System;
using System.Collections.Generic;
using System.Text;
using WebApp.CadastroCliente.Data.Context;
using WebApp.CadastroCliente.Data.Repositorio.Interfaces;
using WebApp.CadastroCliente.Data.Repositorio.Repository.Base;
using WebApp.CadastroCliente.Dominio.Models;

namespace WebApp.CadastroCliente.Data.Repositorio.Repository
{
    public class RepositoryCliente:RepositoryBase<Cliente>, IRepositoryCliente
    {
        public readonly ApplicationContext _context;

        public RepositoryCliente(ApplicationContext context) : base(context)
        {
            _context = context;
        }
    }
}
