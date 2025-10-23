using System.Collections.Generic;

namespace Store.Models
{
    public class StoreViewModel
    {
        public List<Category> Categories { get; set; } = new List<Category>();
        public List<Product> Products { get; set; } = new List<Product>();
        public List<Product> Bestsellers { get; set; } = new List<Product>();
    }
}