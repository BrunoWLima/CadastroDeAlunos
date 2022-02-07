using AutoMapper;
using CadastroDeAlunos.Service;
using CadastroDeAlunos.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CadastroDeAlunos.Web.Controllers
{
    public class AlunoController : Controller
    {
        private readonly IAlunoService AlunoService;
        private readonly IUsuarioService UsuarioService;
        private readonly IMapper Mapper;

        public AlunoController(IAlunoService alunoService, IUsuarioService usuarioService, IMapper mapper)
        {
            AlunoService = alunoService;
            UsuarioService = usuarioService;
            Mapper = mapper;
        }

        public ActionResult Index()
        {
            IEnumerable<AlunoViewModel> model = AlunoService.GetAllAlunos().Select(x => Mapper.Map<AlunoViewModel>(x));

            return View(model.ToList());
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
