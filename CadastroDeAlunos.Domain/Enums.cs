

using System.ComponentModel.DataAnnotations;

namespace CadastroDeAlunos.Domain
{
    public enum PapelUsuario
    {
        [Display(Name = "Master")] Master,
        [Display(Name = "Administrador")] Admin,
        [Display(Name = "Acesso Nível 1")] AcessoNivelUm,
        [Display(Name = "Acesso Nível 2")] AcessoNivelDois
    };

    public enum TipoContato
    {
        [Display(Name = "Celular Corporativo")] CelularCorporativo,
        [Display(Name = "Celular Pessoal")] CelularPessoal,
        [Display(Name = "Telefone Comercial")] TelefoneComercial,
        [Display(Name = "Telefone Residencial")] TelefoneResidencial
    };

    public enum TipoEndereco
    {
        [Display(Name = "Cobrança")] TelefoneComercial,
        [Display(Name = "Comercial")] CelularPessoal,
        [Display(Name = "Entrega")] TelefoneResidencial,
        [Display(Name = "Residencial")] CelularCorporativo
    };
}
