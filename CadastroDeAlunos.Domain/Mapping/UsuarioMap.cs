using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CadastroDeAlunos.Domain.Mapping
{
    public class UsuarioMap
    {
        public UsuarioMap(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(100);
            builder.Property(x => x.UserLogin).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Senha).IsRequired();
            builder.HasOne(x => x.Aluno).WithOne().HasForeignKey<Aluno>(x => x.Id);
        }
    }
}
