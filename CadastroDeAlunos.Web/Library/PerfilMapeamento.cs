using AutoMapper;
using CadastroDeAlunos.Domain;
using CadastroDeAlunos.Web.Models;

namespace CadastroDeFamilias.Api.Library
{
    public class PerfilMapeamento : Profile
    {
        public PerfilMapeamento()
        {
            CreateMap<Usuario, UsuarioViewModel>();
            CreateMap<UsuarioViewModel, Usuario>();
            CreateMap<Aluno, AlunoViewModel>();
            CreateMap<AlunoViewModel, Aluno>();
        }
    }
}
