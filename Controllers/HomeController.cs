using CarClinic.Data;
using CarClinic.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CarClinic.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _banco;
        public HomeController(ApplicationDbContext db)
        {
            _banco = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CarClinic()
        {
            return View();
        }

        public IActionResult StatusServico()
        {
            IEnumerable<PortalModel> listaServicos = _banco.tb_portal;
            return View(listaServicos);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
