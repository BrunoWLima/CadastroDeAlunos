using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CadastroDeAlunos.Web.Models
{
    public class UsuarioViewModel
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Email Usuário")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Usuario Login")]
        public string UserLogin { get; set; }

        [Required]
        [Display(Name = "Senha")]
        public string Senha { get; set; }

        [Required]
        [Display(Name = "Confirmar Senha")]
        public string ConfirmaSenha { get; set; }

        public AlunoViewModel Aluno { get; set; }
    }
}
