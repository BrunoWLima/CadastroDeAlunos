using CadastroDeAlunos.Domain;
using CadastroDeAlunos.Infra;

namespace CadastroDeAlunos.Service
{
    public class AlunoProfileService : IAlunoProfileService
    {
        private IRepository<AlunoProfile> AlunoProfileRepository;

        public AlunoProfileService(IRepository<AlunoProfile> alunoProfileRepository)
        {
            AlunoProfileRepository = alunoProfileRepository;
        }

        public AlunoProfile GetAlunoById(int id)
        {
            return AlunoProfileRepository.GetById(id);
        }
    }
}
