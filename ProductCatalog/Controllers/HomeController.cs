using Microsoft.AspNetCore.Mvc;
using ProductCatalog.Models;
using System.Collections.Generic;

namespace ProductCatalog.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Тауарлар тізімін жасау
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Ноутбук", Price = 450000, Category = "Электроника", IsAvailable = true },
                new Product { Id = 2, Name = "Смартфон", Price = 250000, Category = "Электроника", IsAvailable = true },
                new Product { Id = 3, Name = "Құлаққап", Price = 15000, Category = "Аксессуар", IsAvailable = false }
            };

            // Деректерді View-ге жіберу
            return View(products);
        }
    }
}