using CadastroDeAlunos.Domain;
using System.Collections.Generic;

namespace CadastroDeAlunos.Service
{
    public interface IAlunoService
    {
        void AddAluno(Aluno Aluno);
        void DeleteAluno(int id);
        IEnumerable<Aluno> GetAllAlunos();
        Aluno GetAlunoById(int id);
        void UpdateAluno(Aluno Aluno);
    }
}
