using Microsoft.AspNetCore.Mvc;

namespace SucessoCRUD.Controllers
{
    public class Cadastro : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       public IActionResult Confirmar()
        {
            return View();
        }
    }
}
