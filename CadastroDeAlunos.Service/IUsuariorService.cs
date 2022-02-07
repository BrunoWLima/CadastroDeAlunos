using CadastroDeAlunos.Domain;
using System.Collections.Generic;

namespace CadastroDeAlunos.Service
{
    public interface IUsuarioService
    {
        void AddUser(Usuario usuario);
        void DeleteUser(int id);
        IEnumerable<Usuario> GetAllUsers();
        Usuario GetUserById(int id);
        void UpdateUser(Usuario usuario);
    }
}
