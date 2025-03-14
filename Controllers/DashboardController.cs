using Microsoft.AspNetCore.Mvc;

public class DashboardController : Controller
{
    public IActionResult Dashboard()
    {
        // You can pass the data for the current user's dashboard, like budgets or money goals
        return View();
    }
    
}
