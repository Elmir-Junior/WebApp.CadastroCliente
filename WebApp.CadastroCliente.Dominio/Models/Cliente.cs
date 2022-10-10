using System;
using System.ComponentModel.DataAnnotations;
using WebApp.CadastroCliente.Dominio.Models.Base;

namespace WebApp.CadastroCliente.Dominio.Models
{
    public class Cliente : Entity
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }

        public string CEP { get; set; }
        public string Rua { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
    }
}
