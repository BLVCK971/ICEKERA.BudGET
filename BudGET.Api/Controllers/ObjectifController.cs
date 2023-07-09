using Microsoft.AspNetCore.Mvc;

namespace BudGET.Api.Controllers
{
    public class ObjectifController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
