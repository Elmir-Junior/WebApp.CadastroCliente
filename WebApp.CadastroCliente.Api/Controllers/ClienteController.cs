using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.CadastroCliente.Dominio.Models;
using WebApp.CadastroCliente.Services.Interfaces;
using WebApp.CadastroCliente.Services.Services;

namespace WebApp.CadastroCliente.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IServiceCliente _serviceCliente;

        public ClienteController(IServiceCliente serviceCliente)
        {
            _serviceCliente = serviceCliente;
        }

        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            return _serviceCliente.GetAll();
        }

        // GET api/<ClienteController>/5
        [HttpGet("{id}")]
        public Cliente Get(int id)
        {
            return _serviceCliente.GetById(id);
        }

        [HttpPost("Post/")]
        public void Post([FromBody] Cliente cliente)
        {
            _serviceCliente.Add(cliente);
        }

        [HttpPut("Put/")]
        public void Put([FromBody] Cliente cliente)
        {
            _serviceCliente.Update(cliente);
        }

        [HttpDelete("Delete/{id}")]
        public void Delete(int id)
        {
            var cliente = _serviceCliente.GetById(id);
            _serviceCliente.Remove(cliente);
        }
    }
}
