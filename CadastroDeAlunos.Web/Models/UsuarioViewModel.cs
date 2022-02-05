using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CadastroDeAlunos.Web.Models
{
    public class UsuarioViewModel
    {
        [HiddenInput]
        public int Id { get; set; }

        [Display(Name = "Usuario Login")]
        public string UserLogin { get; set; }

        [Display(Name = "Senha")]
        public string Senha { get; set; }

        [Display(Name = "Confirmar Senha")]
        public string ConfirmaSenha { get; set; }

        public AlunoProfileViewModel AlunoProfile { get; set; }
    }
}
