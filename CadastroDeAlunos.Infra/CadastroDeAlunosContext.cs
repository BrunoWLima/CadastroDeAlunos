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
            new AlunoMap(builder.Entity<Aluno>());

            #region Usuário
            builder.Entity<Usuario>().HasData(new Usuario()
            {
                Id = 1,
                Email = "Email@email.com",
                UserLogin = "admin",
                Senha = "admin123",
                Aluno = null
            });

            #endregion

            base.OnModelCreating(builder);
        }
    }
}
