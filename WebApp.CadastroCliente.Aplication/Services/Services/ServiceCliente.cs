using System.Collections.Generic;
using WebApp.CadastroCliente.Aplication.Services.Base;
using WebApp.CadastroCliente.Dominio.Models;

namespace WebApp.CadastroCliente.Aplication.Services.Services
{
    public class ServiceClienteApi : ServiceBaseApi<Cliente>
    {
        public IEnumerable<Cliente> GetAll()
        {
            return GetAll("/Api/Cliente/");
        }
        public Cliente GetById(int id)
        {
            return GetById("/Api/Cliente/", id);
        }

        public bool Add(Cliente obj)
        {
            return Post("/Api/Cliente/Post", obj);
        }
        public bool Update(Cliente cliente)
        {
            return Put("/Api/Cliente/Put/", cliente);
        }
        public bool Remove(int id)
        {
            return Delete("/Api/Cliente/Delete/" + id);
        }
    }
}
