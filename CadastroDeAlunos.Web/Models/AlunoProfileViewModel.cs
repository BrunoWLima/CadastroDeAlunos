using CadastroDeAlunos.Domain;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CadastroDeAlunos.Web.Models
{
    public class AlunoProfileViewModel
    {

        [HiddenInput]
        public int Id { get; set; }

        [Display(Name = "Nome Completo")]
        public string NomeAluno { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Tipo de Contato")]
        public TipoContato TipoContato { get; set; }

        [Display(Name = "Número do Contato")]
        public string NumeroContato { get; set; }

        [Display(Name = "CEP")]
        public string Cep { get; set; }

        [Display(Name = "Estado")]
        public string Estado { get; set; }

        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Display(Name = "Bairro")]
        public string Bairro { get; set; }

        [Display(Name = "Tipo de Endereço")]
        public TipoEndereco TipoEndereco { get; set; }

        [Display(Name = "Logradouro")]
        public string Logradouro { get; set; }

        [Display(Name = "Número")]
        public string Numero { get; set; }

        [Display(Name = "Complemento")]
        public string Complemento { get; set; }

        public Usuario Usuario { get; set; }
    }
}
