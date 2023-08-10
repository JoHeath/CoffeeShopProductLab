using CoffeeShopProductLab.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace CoffeeShopProductLab.Controllers
{
    public class ProductController : Controller
    {
        private CoffeeProductsDbContext _coffeeProductsDbContext = new CoffeeProductsDbContext();
        public IActionResult Index()
        {
            List<Product> result = _coffeeProductsDbContext.Products.ToList();
            return View(result);
        }
        public IActionResult Details(int id)
        {
            Product p = _coffeeProductsDbContext.Products.FirstOrDefault(x => x.Id == id);
            
            return View(p);
        }
    }
}
