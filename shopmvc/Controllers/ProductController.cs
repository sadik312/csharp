using shopmvc.Models;
using shopmvc.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace shopmvc.Controllers;
public class ProductConroller : Controller
{
    
    private readonly ProductDbContext  _db;

    // make controller
    // called 'dependency injection'
    public ProductController(ProductDbContext db)
    {
        _db = db;
    }
    public IActionResult Products()
    {
        // code that we want to execute when uer visits product/products
        IEnumerable<ProductModel> productList = _db.Product.ToList();
        return View(productList);
    }
}