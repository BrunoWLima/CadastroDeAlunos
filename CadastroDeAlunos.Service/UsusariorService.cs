using CadastroDeAlunos.Domain;
using CadastroDeAlunos.Infra;
using System.Collections.Generic;

namespace CadastroDeAlunos.Service
{
    public class UsusariorService : IUsuarioService
    {
        private IRepository<Usuario> UserRepository;
        private IRepository<AlunoProfile> AlunoProfileRepository;

        public UsusariorService(IRepository<Usuario> userRepository, IRepository<AlunoProfile> alunoProfileRepository)
        {
            UserRepository = userRepository;
            AlunoProfileRepository = alunoProfileRepository;
        }

        public void AddUser(Usuario user)
        {
            UserRepository.Add(user);
        }

        public void DeleteUser(int id)
        {
            AlunoProfile userProfile = AlunoProfileRepository.GetById(id);
            AlunoProfileRepository.Delete(userProfile);
            Usuario user = UserRepository.GetById(id);
            UserRepository.Delete(user);
            UserRepository.SaveChanges();
        }

        public Usuario GetUserById(int id)
        {
            return UserRepository.GetById(id);
        }

        public IEnumerable<Usuario> GetAllUsers()
        {
            return UserRepository.GetAll();
        }

        public void UpdateUser(Usuario user)
        {
            UserRepository.Update(user);
        }
    }
}
