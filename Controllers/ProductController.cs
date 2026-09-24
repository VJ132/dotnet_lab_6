using Microsoft.AspNetCore.Mvc;
using Lab_6.Models;

namespace Lab_6.Controllers
{
    public class ProductController : Controller
    {
        private List<Product> GetProductList()
        {
            List<Product> products = new List<Product>();
            List<string> urls = new List<string>
            {
                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSbRX4P5ykLNYSaM2Hmn2sno_f3jEUzEZq5LAbvMXR1kQ&s=10",
                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSadRWaG0RyYiRO9uk7Z1efNjVuhRMswzPSjP8d2sTK9w&s=10",
                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRESNOo2F8GaHjnnGNdcbUAEWkZesAkU86dihd_UiTs0w&s=10"
            };

            for (int i = 0; i < 3; ++i)
            {
                Product product = new Product
                {
                    PId = i,
                    PName = "Laptop",
                    PCategory = "Electronics",
                    PPrice = 50000 + (double)(5000 * i),
                    PImageUrl = urls[i]
                };
                products.Add(product);
            }
            return products;
        }

        public ActionResult Index()
        {
            var products = GetProductList();
            return View("Product", products);
        }

        public ActionResult Details(int id)
        {
            var products = GetProductList(); // Populate data for this request
            var product = products.FirstOrDefault(x => x.PId == id);

            return View("ProductDetail", product);
        }
    }
}
