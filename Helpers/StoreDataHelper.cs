using Store.Models;

namespace Store.Helpers
{
    public static class StoreDataHelper
    {
        private static readonly List<Category> _categories = new()
        {
            new Category {
                Id = 1,
                Name = "الملابس",
                Description ="قسم الملابس",
                ImageUrl = "/images/clothes.jpg"
            },
            new Category {
                Id = 2,
                Name = "الإكسسوارات",
                Description ="قسم الإكسسوارات",
                ImageUrl = "/images/accessories.jpg"
            },
            new Category {
                Id = 3,
                Name = "الأحذية",
                Description ="قسم الأحذية",
                ImageUrl = "/images/high-heels.jpg"
            },
            new Category {
                Id = 4,
                Name = "كاجوال",
                Description ="قسم الملابس الكاجوال",
                ImageUrl = "/images/casual.jpg"
            },
            new Category {
                Id = 5,
                Name = "الشتوي",
                Description ="قسم الملابس الشتوي",
                ImageUrl = "/images/winter.jpg"
            },
        };

        private static readonly List<Product> _products = new()
        {
            // الملابس (Clothes) - Category 1
            new Product {
                Id = 1, Name = "فستان صيفي مريح",
                Description = "فستان خفيف وأنيق للصيف",
                Price = 120,
                ImageUrl = "/images/products/comfortable-summer-dress.jpg",
                CategoryId = 1
            },
            new Product {
                Id = 2, Name = "فستان أبيض قصير",
                Description = "فستان أبيض أنيق للمناسبات",
                Price = 150,
                ImageUrl = "/images/products/short-white-dress.jpg",
                CategoryId = 1
            },
            new Product {
                Id = 3, Name = "قميص حريري",
                Description = "قميص حريري أنيق للنساء",
                Price = 180,
                ImageUrl = "/images/products/silk-blouse.jpg",
                CategoryId = 1
            },
            new Product {
                Id = 4, Name = "تنورة ميدي",
                Description = "تنورة ميدي أنيقة ومريحة",
                Price = 100,
                ImageUrl = "/images/products/midi-skirt.jpg",
                CategoryId = 1
            },
            new Product {
                Id = 5, Name = "قميص مخطط",
                Description = "قميص قطني مخطط بألوان جميلة",
                Price = 80,
                ImageUrl = "/images/products/striped-tshirt.jpg",
                CategoryId = 1
            },

            // الإكسسوارات (Accessories) - Category 2
            new Product {
                Id = 6, Name = "سوار ذهبي",
                Description = "سوار ذهبي أنيق للنساء",
                Price = 250,
                ImageUrl = "/images/products/gold-bangle-bracelet.jpg",
                CategoryId = 2
            },
            new Product {
                Id = 7, Name = "قلادة لؤلؤ",
                Description = "قلادة لؤلؤ فاخرة وأنيقة",
                Price = 300,
                ImageUrl = "/images/products/pearl-necklace.jpg",
                CategoryId = 2
            },
            new Product {
                Id = 8, Name = "حقيبة كتف",
                Description = "حقيبة كتف أنيقة وعملية",
                Price = 200,
                ImageUrl = "/images/products/shoulder-bag.jpg",
                CategoryId = 2
            },
            new Product {
                Id = 9, Name = "نظارات شمسية دائرية",
                Description = "نظارات شمسية دائرية أنيقة",
                Price = 120,
                ImageUrl = "/images/products/round-sunglasses.jpg",
                CategoryId = 2
            },
            new Product {
                Id = 10, Name = "قبعة واسعة الحواف",
                Description = "قبعة واسعة الحواف أنيقة للصيف",
                Price = 90,
                ImageUrl = "/images/products/wide-brim-hat.jpg",
                CategoryId = 2
            },

            // الأحذية (Shoes) - Category 3
            new Product {
                Id = 11, Name = "كعب عالي ملون",
                Description = "كعب عالي ملون أنيق ومريح",
                Price = 180,
                ImageUrl = "/images/products/colorful-thick-heeled-shoes.jpg",
                CategoryId = 3
            },
            new Product {
                Id = 12, Name = "صندل بكعب متوسط",
                Description = "صندل بكعب متوسط مريح للصيف",
                Price = 150,
                ImageUrl = "/images/products/medium-heeled-sandals.jpg",
                CategoryId = 3
            },
            new Product {
                Id = 13, Name = "حذاء مسطح أنيق",
                Description = "حذاء مسطح أنيق ومريح",
                Price = 120,
                ImageUrl = "/images/products/elegant-flat-shoes.jpg",
                CategoryId = 3
            },
            new Product {
                Id = 14, Name = "حذاء منصة",
                Description = "حذاء منصة عصري ومريح",
                Price = 160,
                ImageUrl = "/images/products/platform-shoes.jpg",
                CategoryId = 3
            },
            new Product {
                Id = 15, Name = "كعب عالي كلاسيكي",
                Description = "كعب عالي كلاسيكي أنيق",
                Price = 200,
                ImageUrl = "/images/products/high-heels.jpg",
                CategoryId = 3
            },

            // كاجوال (Casual) - Category 4
            new Product {
                Id = 16, Name = "قميص قطني ملون",
                Description = "قميص قطني ملون مريح للكاجوال",
                Price = 70,
                ImageUrl = "/images/products/colored-cotton-t-shirts.jpg",
                CategoryId = 4
            },
            new Product {
                Id = 17, Name = "شورت جينز",
                Description = "شورت جينز مريح للصيف",
                Price = 90,
                ImageUrl = "/images/products/denim-shorts.jpg",
                CategoryId = 4
            },
            new Product {
                Id = 18, Name = "جينز ضيق",
                Description = "جينز ضيق أنيق ومريح",
                Price = 110,
                ImageUrl = "/images/products/skinny-jeans.jpg",
                CategoryId = 4
            },
            new Product {
                Id = 19, Name = "هودي",
                Description = "هودي مريح وأنيق للكاجوال",
                Price = 85,
                ImageUrl = "/images/products/hooded-sweatshirt.jpg",
                CategoryId = 4
            },
            new Product {
                Id = 20, Name = "قميص مخطط",
                Description = "قميص مخطط مريح للكاجوال",
                Price = 75,
                ImageUrl = "/images/products/striped-tshirt.jpg",
                CategoryId = 4
            },

            // الشتوي (Winter) - Category 5
            new Product {
                Id = 21, Name = "جاكيت جلدي كلاسيكي",
                Description = "جاكيت جلدي كلاسيكي أنيق للشتاء",
                Price = 350,
                ImageUrl = "/images/products/classic-leather-jacket.jpg",
                CategoryId = 5
            },
            new Product {
                Id = 22, Name = "معطف صوفي طويل",
                Description = "معطف صوفي طويل دافئ وأنيق",
                Price = 280,
                ImageUrl = "/images/products/long-wool-coat.jpg",
                CategoryId = 5
            },
            new Product {
                Id = 23, Name = "جاكيت منتفخ",
                Description = "جاكيت منتفخ دافئ ومريح",
                Price = 200,
                ImageUrl = "/images/products/puffer-jacket.jpg",
                CategoryId = 5
            },
            new Product {
                Id = 24, Name = "كنزة صوفية سميكة",
                Description = "كنزة صوفية سميكة دافئة ومريحة",
                Price = 150,
                ImageUrl = "/images/products/thick-wool-sweater.jpg",
                CategoryId = 5
            },
            new Product {
                Id = 25, Name = "وشاح صوفي ملون",
                Description = "وشاح صوفي ملون دافئ وأنيق",
                Price = 80,
                ImageUrl = "/images/products/colorful-wool-scarf.jpg",
                CategoryId = 5
            }
        };

        // Methods for Categories
        public static List<Category> GetAllCategories()
        {
            return _categories.ToList();
        }

        public static Category? GetCategoryById(int id)
        {
            return _categories.FirstOrDefault(c => c.Id == id);
        }

        public static Category? GetCategoryByName(string name)
        {
            return _categories.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        // Methods for Products
        public static List<Product> GetAllProducts()
        {
            return _products.ToList();
        }

        public static Product? GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public static List<Product> GetProductsByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public static List<Product> GetProductsByCategoryName(string categoryName)
        {
            var category = GetCategoryByName(categoryName);
            if (category == null) return new List<Product>();

            return GetProductsByCategory(category.Id);
        }

        public static List<Product> SearchProducts(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return GetAllProducts();

            return _products.Where(p =>
                p.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                p.Description.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)
            ).ToList();
        }

        public static List<Product> GetProductsByPriceRange(decimal minPrice, decimal maxPrice)
        {
            return _products.Where(p => p.Price >= minPrice && p.Price <= maxPrice).ToList();
        }

        public static List<Product> GetFeaturedProducts(int count = 5)
        {
            return _products.OrderByDescending(p => p.Price).Take(count).ToList();
        }

        public static List<Product> GetLatestProducts(int count = 5)
        {
            return _products.OrderByDescending(p => p.Id).Take(count).ToList();
        }

        public static List<Product> GetBestsellers(int count = 8)
        {
            // محاكاة المنتجات الأكثر مبيعاً بناءً على السعر والتصنيف
            // في التطبيق الحقيقي، هذا سيأتي من قاعدة البيانات
            return _products
                .OrderByDescending(p => p.Price) // المنتجات الأغلى عادة أكثر مبيعاً
                .ThenByDescending(p => p.Id) // ثم الأحدث
                .Take(count)
                .ToList();
        }

        // Statistics Methods
        public static int GetTotalProductsCount()
        {
            return _products.Count;
        }

        public static int GetProductsCountByCategory(int categoryId)
        {
            return _products.Count(p => p.CategoryId == categoryId);
        }

        public static decimal GetAveragePrice()
        {
            return _products.Average(p => p.Price);
        }

        public static decimal GetMinPrice()
        {
            return _products.Min(p => p.Price);
        }

        public static decimal GetMaxPrice()
        {
            return _products.Max(p => p.Price);
        }

        // Helper method to get products with their categories
        public static List<Product> GetProductsWithCategories()
        {
            return _products.Select(p => new Product
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                Price = p.Price,
                ImageUrl = p.ImageUrl,
                CategoryId = p.CategoryId,
                Category = _categories.FirstOrDefault(c => c.Id == p.CategoryId)
            }).ToList();
        }
    }
}
