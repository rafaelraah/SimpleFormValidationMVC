using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleFormValidationMVC.Models;

namespace SimpleFormValidationMVC.Controllers
{
    public class FilmeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Salvar(Filme Filme)
        {
            if (!ModelState.IsValid)
            {
                return View("Error");
            }
            Filme.DataAvaliacao = DateTime.Now;
            Filme.Id = Guid.NewGuid();
            return View("Sucesso", Filme);
        }
    }
}