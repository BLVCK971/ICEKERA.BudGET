using Microsoft.AspNetCore.Mvc;

namespace BudGET.Api.Controllers
{
    public class SalaireController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
