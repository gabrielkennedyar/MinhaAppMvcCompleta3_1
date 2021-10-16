using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MinhaApp.Business.Interfaces;
using MinhaApp.Data.Context;
using MinhaApp.Site.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaApp.Site.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFornecedorRepository _fornecedorRepository;

        public HomeController(IFornecedorRepository fornecedorRepository)
        {
            _fornecedorRepository = fornecedorRepository;
        }

        public async Task<IActionResult> Index()
        {
            var teste = await _fornecedorRepository.ObterTodos();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
