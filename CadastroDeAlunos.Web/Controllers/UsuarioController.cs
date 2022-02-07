using AutoMapper;
using CadastroDeAlunos.Domain;
using CadastroDeAlunos.Service;
using CadastroDeAlunos.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CadastroDeAlunos.Web.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService UsuarioService;
        private readonly IAlunoService AlunoService;
        private readonly IMapper Mapper;

        public UsuarioController(IUsuarioService usuarioService, IAlunoService alunoService, IMapper mapper)
        {
            UsuarioService = usuarioService;
            AlunoService = alunoService;
            Mapper = mapper;
        }

        public IActionResult Index()
        {
            IEnumerable<UsuarioViewModel> model = UsuarioService.GetAllUsers().Select(x => Mapper.Map<UsuarioViewModel>(x));

            return View(model.ToList());
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
            UsuarioViewModel model = new();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UsuarioViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(model);

                // TODO: Fazer as validações.

                UsuarioService.AddUser(Mapper.Map<Usuario>(model));
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(model);
            }
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UsuarioViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(model);

                // TODO: Fazer as validações.

                UsuarioService.UpdateUser(Mapper.Map<Usuario>(model));
                return RedirectToAction("Index");
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
        public ActionResult Delete(int id, Usuario model)
        {
            try
            {
                UsuarioService.DeleteUser(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
