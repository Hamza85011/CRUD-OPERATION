using Microsoft.AspNetCore.Mvc;

namespace CRUD_OPERATIONS.Controllers
{
    public class UserController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
