using Microsoft.AspNetCore.Mvc;

namespace BudGET.Api.Controllers
{
    public class DepenseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
