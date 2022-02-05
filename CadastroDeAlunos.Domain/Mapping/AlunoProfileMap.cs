using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CadastroDeAlunos.Domain.Mapping
{
    public class AlunoProfileMap
    {
        public AlunoProfileMap(EntityTypeBuilder<AlunoProfile> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.NomeAluno).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.TipoContato).IsRequired();
            builder.Property(x => x.NumeroContato).IsRequired();
            builder.Property(x => x.Cep).IsRequired();
            builder.Property(x => x.Estado).IsRequired();
            builder.Property(x => x.Cidade).IsRequired();
            builder.Property(x => x.Bairro).IsRequired();
            builder.Property(x => x.TipoEndereco).IsRequired();
            builder.Property(x => x.Logradouro).IsRequired();
            builder.Property(x => x.Numero).IsRequired();
            builder.Property(x => x.Complemento).IsRequired();
        }
    }
}
