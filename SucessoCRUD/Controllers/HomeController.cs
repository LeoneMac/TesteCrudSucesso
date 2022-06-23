using Microsoft.AspNetCore.Mvc;
using SucessoCRUD.Models;
using System.Diagnostics;

namespace SucessoCRUD.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}