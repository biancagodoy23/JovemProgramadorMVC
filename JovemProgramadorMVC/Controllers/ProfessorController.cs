using JovemProgramadorMVC.Data.Repositorio.Interface;
using JovemProgramadorMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace primeiroprojetoMVC.Controllers
{
    public class ProfessorController : Controller

    {
        private readonly IProfessorRepositorio _professorrepositorio;

        public ProfessorController(IProfessorRepositorio professorRepositorio)
        {
            _professorrepositorio = professorRepositorio;
        }
        public IActionResult Index()
        {
            var professor = _professorrepositorio.BuscarProfessor();
            return View(professor);
        }

        public IActionResult AdicionarProfessor()
        {
            return View();
        }

        public IActionResult InserirProfessor(Professor professor)
        {
            try
            {
                _professorrepositorio.InserirProfessor(professor);
            }
            catch (Exception)
            {

                throw;
            }

            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id)
        {
            var professor = _professorrepositorio.BuscarId(id);
            return View(professor);
        }

        public IActionResult Editar(Professor professor)
        {
            return RedirectToAction("Index");
        }

        public IActionResult Excluir(Professor professor)
        {
            _professorrepositorio.Excluir(professor);
            return RedirectToAction("Index");
       }
    }

}