namespace CadastroDeAlunos.Domain
{
    public class Usuario : BaseEntity
    {
        public string Email { get; set; }
        public string UserLogin { get; set; }
        public string Senha { get; set; }
        public Aluno Aluno { get; set; }
    }
}
