using System;
using System.Collections.Generic;
using System.Text;
using WebApp.CadastroCliente.Data.Repositorio.Interfaces.Base;
using WebApp.CadastroCliente.Dominio.Models;

namespace WebApp.CadastroCliente.Data.Repositorio.Interfaces
{
    public interface IRepositoryCliente:IRepository<Cliente>
    {
    }
}
