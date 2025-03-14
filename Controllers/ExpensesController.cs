using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ExpensesController : Controller
    {
        public IActionResult Expenses()
        {
            return View();
        }
    }
}
