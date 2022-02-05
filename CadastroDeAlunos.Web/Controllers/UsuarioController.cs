using AutoMapper;
using CadastroDeAlunos.Service;
using CadastroDeAlunos.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CadastroDeAlunos.Web.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService UsuarioService;
        private readonly IAlunoProfileService AlunoProfileService;
        private readonly IMapper Mapper;

        public UsuarioController(IUsuarioService usuarioService, IAlunoProfileService alunoProfileService, IMapper mapper)
        {
            UsuarioService = usuarioService;
            AlunoProfileService = alunoProfileService;
            Mapper = mapper;
        }

        public IActionResult Index()
        {
            List<UsuarioViewModel> model = new();

            UsuarioService.GetAllUsers().ToList().ForEach(u =>
            {
                u.AlunoProfile = AlunoProfileService.GetAlunoById(u.Id);
                model.Add(Mapper.Map<UsuarioViewModel>(u));
            });

            return View(model);
        }
    }
}
