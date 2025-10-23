# Store Helpers Documentation

## StoreDataHelper

هذا الـ Helper يحتوي على جميع البيانات والوظائف المتعلقة بالتصنيفات والمنتجات.

### الوظائف المتاحة:

#### التصنيفات (Categories):

- `GetAllCategories()` - الحصول على جميع التصنيفات
- `GetCategoryById(int id)` - الحصول على تصنيف بالمعرف
- `GetCategoryByName(string name)` - الحصول على تصنيف بالاسم

#### المنتجات (Products):

- `GetAllProducts()` - الحصول على جميع المنتجات
- `GetProductById(int id)` - الحصول على منتج بالمعرف
- `GetProductsByCategory(int categoryId)` - الحصول على منتجات تصنيف محدد
- `GetProductsByCategoryName(string categoryName)` - الحصول على منتجات تصنيف بالاسم
- `SearchProducts(string searchTerm)` - البحث في المنتجات
- `GetProductsByPriceRange(decimal minPrice, decimal maxPrice)` - الحصول على منتجات ضمن نطاق سعري
- `GetFeaturedProducts(int count = 5)` - الحصول على المنتجات المميزة
- `GetLatestProducts(int count = 5)` - الحصول على أحدث المنتجات
- `GetProductsWithCategories()` - الحصول على المنتجات مع تصنيفاتها

#### الإحصائيات (Statistics):

- `GetTotalProductsCount()` - إجمالي عدد المنتجات
- `GetProductsCountByCategory(int categoryId)` - عدد منتجات تصنيف محدد
- `GetAveragePrice()` - متوسط الأسعار
- `GetMinPrice()` - أقل سعر
- `GetMaxPrice()` - أعلى سعر

### مثال على الاستخدام:

```csharp
// الحصول على جميع التصنيفات
var categories = StoreDataHelper.GetAllCategories();

// الحصول على منتجات تصنيف محدد
var clothesProducts = StoreDataHelper.GetProductsByCategory(1);

// البحث في المنتجات
var searchResults = StoreDataHelper.SearchProducts("فستان");

// الحصول على المنتجات المميزة
var featuredProducts = StoreDataHelper.GetFeaturedProducts(3);
```

## CartHelper

هذا الـ Helper يحتوي على جميع الوظائف المتعلقة بعربة التسوق.

### الوظائف المتاحة:

- `GetCartItems()` - الحصول على عناصر العربة
- `AddToCart(Product product, int quantity = 1)` - إضافة منتج للعربة
- `RemoveFromCart(int productId)` - إزالة منتج من العربة
- `UpdateQuantity(int productId, int quantity)` - تحديث كمية منتج
- `ClearCart()` - مسح العربة بالكامل
- `GetCartItemsCount()` - عدد العناصر في العربة
- `GetCartTotal()` - إجمالي سعر العربة
- `IsProductInCart(int productId)` - التحقق من وجود منتج في العربة
- `GetCartItem(int productId)` - الحصول على عنصر من العربة

### مثال على الاستخدام:

```csharp
// إضافة منتج للعربة
var product = StoreDataHelper.GetProductById(1);
CartHelper.AddToCart(product, 2);

// الحصول على إجمالي العربة
var total = CartHelper.GetCartTotal();

// التحقق من وجود منتج في العربة
var isInCart = CartHelper.IsProductInCart(1);
```

## المزايا:

1. **تنظيم الكود**: فصل البيانات والمنطق عن الـ Controllers
2. **إعادة الاستخدام**: يمكن استخدام الـ Helpers في أي مكان في التطبيق
3. **سهولة الصيانة**: تعديل البيانات في مكان واحد فقط
4. **الوظائف المتقدمة**: البحث، التصفية، والإحصائيات
5. **مرونة الاستخدام**: يمكن إضافة وظائف جديدة بسهولة

## التحديثات المستقبلية:

يمكن تحسين هذه الـ Helpers لاحقاً لتدعم:

- قاعدة البيانات الحقيقية
- التخزين المؤقت (Caching)
- التصفح والترقيم (Pagination)
- المزيد من خيارات البحث والتصفية
