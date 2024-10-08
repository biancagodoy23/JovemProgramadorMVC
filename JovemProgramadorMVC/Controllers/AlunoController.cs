﻿using JovemProgramadorMVC.Data.Repositorio.Interface;
using JovemProgramadorMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace primeiroprojetoMVC.Controllers
{
    public class AlunoController : Controller

    {
        private readonly IAlunoRepositorio _alunorepositorio;

        public AlunoController(IAlunoRepositorio alunoRepositorio)
        {
            _alunorepositorio = alunoRepositorio;
        }
        public IActionResult Index()
        {
            var aluno = _alunorepositorio.BuscarAlunos();
            return View(aluno);
        }

        public IActionResult AdicionarAluno()
        {
            return View();
        }

        public IActionResult InserirAluno(Aluno aluno) 
        {
            try
            {
                _alunorepositorio.InserirAluno(aluno);
            }
            catch (Exception)
            {

                throw;
            }

            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id)
        {
            var aluno = _alunorepositorio.BuscarId(id);
            return View(aluno);
        }

        public IActionResult Editar(Aluno aluno)
        {
           return RedirectToAction("Index");
        }

        public IActionResult Excluir(Aluno aluno)
        {
            _alunorepositorio.Excluir(aluno);
            return RedirectToAction("Index");
        }
    }

}


