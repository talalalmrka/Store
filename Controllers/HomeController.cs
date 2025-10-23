using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Store.Models;
using Store.Helpers;

namespace Store.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var viewModel = new StoreViewModel
        {
            Categories = StoreDataHelper.GetAllCategories(),
            Products = StoreDataHelper.GetAllProducts(),
            Bestsellers = StoreDataHelper.GetBestsellers(8)
        };
        return View(viewModel);
    }

    public IActionResult Categories()
    {
        return View(StoreDataHelper.GetAllCategories());
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Store()
    {
        var viewModel = new StoreViewModel
        {
            Categories = StoreDataHelper.GetAllCategories(),
            Products = StoreDataHelper.GetAllProducts()
        };
        return View(viewModel);
    }

    public IActionResult CategoryProducts(int categoryId)
    {
        var categoryProducts = StoreDataHelper.GetProductsByCategory(categoryId);
        var category = StoreDataHelper.GetCategoryById(categoryId);

        var viewModel = new StoreViewModel
        {
            Categories = StoreDataHelper.GetAllCategories(),
            Products = categoryProducts
        };

        ViewBag.CategoryName = category?.Name ?? "التصنيف";
        return View("Store", viewModel);
    }

    public IActionResult AddToCart(int id)
    {
        var product = StoreDataHelper.GetProductById(id);
        if (product != null)
        {
            CartHelper.AddToCart(product);
        }
        return RedirectToAction("Cart");
    }

    public IActionResult Cart()
    {
        return View(CartHelper.GetCartItems());
    }

    public IActionResult Remove(int id)
    {
        CartHelper.RemoveFromCart(id);
        return RedirectToAction("Cart");
    }

    public IActionResult UpdateCartQuantity(int id, int quantity)
    {
        CartHelper.UpdateQuantity(id, quantity);
        return RedirectToAction("Cart");
    }

    public IActionResult ClearCart()
    {
        CartHelper.ClearCart();
        return RedirectToAction("Cart");
    }

    // New methods using the helper
    public IActionResult Search(string query)
    {
        var searchResults = StoreDataHelper.SearchProducts(query);
        var viewModel = new StoreViewModel
        {
            Categories = StoreDataHelper.GetAllCategories(),
            Products = searchResults
        };

        ViewBag.SearchQuery = query;
        return View("Store", viewModel);
    }

    public IActionResult Featured()
    {
        var featuredProducts = StoreDataHelper.GetFeaturedProducts();
        var viewModel = new StoreViewModel
        {
            Categories = StoreDataHelper.GetAllCategories(),
            Products = featuredProducts
        };

        ViewBag.PageTitle = "المنتجات المميزة";
        return View("Store", viewModel);
    }

    public IActionResult Latest()
    {
        var latestProducts = StoreDataHelper.GetLatestProducts();
        var viewModel = new StoreViewModel
        {
            Categories = StoreDataHelper.GetAllCategories(),
            Products = latestProducts
        };

        ViewBag.PageTitle = "أحدث المنتجات";
        return View("Store", viewModel);
    }

    public IActionResult ProductDetails(int id)
    {
        var product = StoreDataHelper.GetProductById(id);
        if (product == null)
            return NotFound();

        // إضافة التصنيف للمنتج
        product.Category = StoreDataHelper.GetCategoryById(product.CategoryId);

        return View(product);
    }

    public IActionResult Bestsellers()
    {
        var bestsellers = StoreDataHelper.GetBestsellers();
        var viewModel = new StoreViewModel
        {
            Categories = StoreDataHelper.GetAllCategories(),
            Products = bestsellers
        };

        ViewBag.PageTitle = "المنتجات الأكثر مبيعاً";
        return View("Store", viewModel);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
