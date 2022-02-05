using CadastroDeAlunos.Domain;

namespace CadastroDeAlunos.Service
{
    public interface IAlunoProfileService
    {
        AlunoProfile GetAlunoById(int id);
    }
}
