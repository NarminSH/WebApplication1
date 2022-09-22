using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var products = new List<Product> {
            new Product
            { Name = "Fresh Organic Kiwi",
              StartPrice = 10,
              Price = 90,
              Rate = 5,
              ProductPhotos = new List<ProductPhoto>{new ProductPhoto
              {
                Url = "/images/products/product-image-2-1.jpg"
                }
              },
            },new Product
            { Name = "Dried Mango",
              StartPrice = 10,
              Price = 70,
              Rate = 5,
              ProductPhotos = new List<ProductPhoto>{new ProductPhoto
              {
                Url = "/images/products/product-image-1-2.jpg"
                }
              },
            }, new Product
            { Name = "Dried Banana",
              StartPrice = 60,
              Price = 80,
              Rate = 4,
              ProductPhotos = new List<ProductPhoto>{new ProductPhoto
              {
                Url = "/images/products/product-image-3-1.jpg"
                }
              },
            }, new Product
            { Name = "Crunchy Chips",
              StartPrice = 50,
              Price = 90,
              Rate = 4,
              ProductPhotos = new List<ProductPhoto>{new ProductPhoto
              {
                Url = "/images/products/product-image-4-1.jpg"
                }
              },
            }};
            return View(products);
        }

        public IActionResult Privacy()
        {
            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
