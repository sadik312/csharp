using Microsoft.AspNetCore;
using shopmvc.Models;
using shopmvc.Data;
using Microsoft.AspNetCore.Mvc;

namespace shopmvc.Controllers;
public class ProductConroller : Controller
{
    public IActionResult Products()
    {
        // code that we want to execute when uer visits product/products
        IEnumerable<ProductModel> productList = _db.Product.ToList();
    }
}