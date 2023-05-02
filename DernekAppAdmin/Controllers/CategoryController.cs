using Microsoft.AspNetCore.Mvc;

namespace DernekAppAdmin.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
