using CadastroDeAlunos.Domain;
using CadastroDeAlunos.Infra;
using System.Collections.Generic;

namespace CadastroDeAlunos.Service
{
    public class AlunoService : IAlunoService
    {
        private readonly IRepository<Aluno> AlunoRepository;
        private readonly IRepository<Usuario> UserRepository;

        public AlunoService(IRepository<Aluno> alunoRepository, IRepository<Usuario> userRepository)
        {
            AlunoRepository = alunoRepository;
            UserRepository = userRepository;
        }

        public void AddAluno(Aluno aluno)
        {
            AlunoRepository.Add(aluno);
        }

        public void DeleteAluno(int id)
        {
            Usuario user = UserRepository.GetById(id);
            UserRepository.Delete(user);
            Aluno aluno = AlunoRepository.GetById(id);
            AlunoRepository.Delete(aluno);
        }

        public IEnumerable<Aluno> GetAllAlunos()
        {
            return AlunoRepository.GetAll();
        }

        public Aluno GetAlunoById(int id)
        {
            return AlunoRepository.GetById(id);
        }

        public void UpdateAluno(Aluno aluno)
        {
            AlunoRepository.Update(aluno);
        }
    }
}
