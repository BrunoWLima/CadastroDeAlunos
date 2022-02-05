namespace CadastroDeAlunos.Domain
{
    public class AlunoProfile : BaseEntity
    {
        public string NomeAluno { get; set; }
        public string Email { get; set; }
        public TipoContato TipoContato { get; set; }
        public string NumeroContato { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public TipoEndereco TipoEndereco { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
