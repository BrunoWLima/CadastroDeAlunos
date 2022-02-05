using CadastroDeAlunos.Domain;
using CadastroDeAlunos.Domain.Mapping;
using Microsoft.EntityFrameworkCore;

namespace CadastroDeAlunos.Infra
{
    public class CadastroDeAlunosContext : DbContext
    {
        public CadastroDeAlunosContext(DbContextOptions<CadastroDeAlunosContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            new UsuarioMap(builder.Entity<Usuario>());
            new AlunoProfileMap(builder.Entity<AlunoProfile>());
            base.OnModelCreating(builder);
        }
    }
}
