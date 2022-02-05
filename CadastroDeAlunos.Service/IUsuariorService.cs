using CadastroDeAlunos.Domain;
using System.Collections.Generic;

namespace CadastroDeAlunos.Service
{
    public interface IUsuarioService
    {
        IEnumerable<Usuario> GetAllUsers();
        Usuario GetUserById(int id);
        void AddUser(Usuario user);
        void UpdateUser(Usuario user);
        void DeleteUser(int id);
    }
}
