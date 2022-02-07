using CadastroDeAlunos.Domain;
using CadastroDeAlunos.Infra;
using System.Collections.Generic;

namespace CadastroDeAlunos.Service
{
    public class UsusariorService : IUsuarioService
    {
        private readonly IRepository<Aluno> AlunoRepository;
        private readonly IRepository<Usuario> UserRepository;

        public UsusariorService(IRepository<Aluno> alunoRepository, IRepository<Usuario> userRepository)
        {
            AlunoRepository = alunoRepository;
            UserRepository = userRepository;
        }

        public void AddUser(Usuario user)
        {
            UserRepository.Add(user);
        }

        public void DeleteUser(int id)
        {
            Aluno aluno = AlunoRepository.GetById(id);
            AlunoRepository.Delete(aluno);
            Usuario user = UserRepository.GetById(id);
            UserRepository.Delete(user);
        }

        public IEnumerable<Usuario> GetAllUsers()
        {
            return UserRepository.GetAll();
        }

        public Usuario GetUserById(int id)
        {
            return UserRepository.GetById(id);
        }

        public void UpdateUser(Usuario user)
        {
            UserRepository.Update(user);
        }
    }
}
