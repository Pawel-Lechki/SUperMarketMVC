using Microsoft.AspNetCore.Mvc;

namespace SuperMarket.Controllers;

public class CategoriesController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}