using Microsoft.EntityFrameworkCore;
using WebApp.CadastroCliente.Dominio.Models;

namespace WebApp.CadastroCliente.Data.Context
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext()
        { }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }

    }
}
