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
    [HttpGet]
    public IActionResult Edit([FromRoute]int? id)
    {
        //var category = new Category { CategoryId = id.HasValue ? id.Value : 0 };
        var category = CategoryRepository.GetCategoryById(id.HasValue?id.Value:0);
        return View(category);
    }
    [HttpPost]
    public IActionResult Edit(Category category)
    {
        if (ModelState.IsValid)
        {
            CategoryRepository.UpdateCategory(category.CategoryId, category);
            return RedirectToAction(nameof(Index));
        }

        return View(category);
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add([FromForm] Category category)
    {
        if (ModelState.IsValid)
        {
            CategoryRepository.AddCategory(category);
            return RedirectToAction(nameof(Index));
        }

        return View(category);
    }
}