namespace CadastroDeAlunos.Domain
{
    public class Usuario : BaseEntity
    {
        public string UserLogin { get; set; }
        public string Senha { get; set; }
        public virtual AlunoProfile AlunoProfile { get; set; }
    }
}
