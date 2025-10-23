using Microsoft.AspNetCore.Mvc;
using Store.Models;

namespace Store.Controllers
{
    public class StoreController : Controller
    {
        private static List<Product> Products = new()
        {
            new Product { Id = 1, Name = "فستان صيفي", Description = "فستان خفيف وأنيق", Price = 120, ImageUrl = "/images/dress1.jpg" },
            new Product { Id = 2, Name = "حقيبة يد", Description = "حقيبة جلد فاخرة", Price = 200, ImageUrl = "/images/bag1.jpg" },
            new Product { Id = 3, Name = "كعب نسائي", Description = "كعب مريح وأنيق", Price = 180, ImageUrl = "/images/heels1.jpg" }
        };

        // Renamed to avoid conflict with method
        private static List<CartItem> CartItems = new();

        public IActionResult Index()
        {
            return View(Products);
        }

        public IActionResult AddToCart(int id)
        {
            var product = Products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                var existing = CartItems.FirstOrDefault(c => c.Product.Id == id);
                if (existing != null)
                    existing.Quantity++;
                else
                    CartItems.Add(new CartItem { Product = product, Quantity = 1 });
            }
            return RedirectToAction("Cart");
        }

        public IActionResult Cart()
        {
            return View(CartItems);
        }

        public IActionResult Remove(int id)
        {
            var item = CartItems.FirstOrDefault(c => c.Product.Id == id);
            if (item != null) CartItems.Remove(item);
            return RedirectToAction("Cart");
        }
    }
}
