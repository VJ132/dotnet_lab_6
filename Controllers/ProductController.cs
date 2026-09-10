using Microsoft.AspNetCore.Mvc;
using Expirement_6.Models;

namespace Expirement_6.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>();

            GenerateProductData(products);

            return View("Product", products);
        }

        public void GenerateProductData(List<Product> products)
        {
            List<string> urls = new List<string>
            {
                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSbRX4P5ykLNYSaM2Hmn2sno_f3jEUzEZq5LAbvMXR1kQ&s=10",
                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSadRWaG0RyYiRO9uk7Z1efNjVuhRMswzPSjP8d2sTK9w&s=10",
                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRESNOo2F8GaHjnnGNdcbUAEWkZesAkU86dihd_UiTs0w&s=10"
            };

            for (int i = 0; i < 3; i++)
            {
                Product product = new Product
                {
                    PId = i,
                    PName = "Laptop",
                    PCategory = "Electronics",
                    PPrice = 50000 + (5000 * i),
                    PImageUrl = urls[i]
                };

                products.Add(product);
            }
        }
    }
}
