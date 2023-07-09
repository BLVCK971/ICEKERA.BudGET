using Microsoft.AspNetCore.Mvc;

namespace BudGET.Api.Controllers
{
    public class CompteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
