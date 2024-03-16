using Microsoft.AspNetCore.Mvc;
using SuperMarket.Models;

namespace SuperMarket.Controllers;

public class CategoriesController : Controller
{
    // GET
    public IActionResult Index()
    {
        var categories = CategoryRepository.GetCategories();
        return View(categories);
    }
    
    public IActionResult Edit([FromRoute]int? id)
    {
        //var category = new Category { CategoryId = id.HasValue ? id.Value : 0 };
        var category = CategoryRepository.GetCategoryById(id.HasValue?id.Value:0);
        return View(category);
    }
    
    
}