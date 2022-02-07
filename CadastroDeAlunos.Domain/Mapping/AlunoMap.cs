using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CadastroDeAlunos.Domain.Mapping
{
    public class AlunoMap
    {
        public AlunoMap(EntityTypeBuilder<Aluno> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.NomeAluno).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(100);
            builder.Property(x => x.TipoContato).IsRequired();
            builder.Property(x => x.NumeroContato).IsRequired().HasMaxLength(16);
            builder.Property(x => x.Cep).IsRequired().HasMaxLength(8);
            builder.Property(x => x.Estado).IsRequired();
            builder.Property(x => x.Cidade).IsRequired();
            builder.Property(x => x.Bairro).IsRequired().HasMaxLength(150);
            builder.Property(x => x.TipoEndereco).IsRequired();
            builder.Property(x => x.Logradouro).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Numero).IsRequired();
            builder.Property(x => x.Complemento).HasMaxLength(200);
        }
    }
}
