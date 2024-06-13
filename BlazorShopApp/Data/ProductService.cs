using BlazorShopApp.Models;
using static System.Net.Mime.MediaTypeNames;


namespace BlazorShopApp.Data
{
    public class ProductService
    {
        private readonly List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Product 1", Description = "Top Hat", ImageUrl = "images/image1.jpg", Price = 10 },
            new Product { Id = 2, Name = "Product 2", Description = "Accessories", ImageUrl = "images/image2.jpg", Price = 20 },
            new Product { Id = 3, Name = "Product 3", Description = "Sweater", ImageUrl = "images/image3.jpg", Price = 30 },
            new Product { Id = 4, Name = "Product 4", Description = "Fancy Pants", ImageUrl = "images/image4.jpg", Price = 40 },
            new Product { Id = 5, Name = "Product 5", Description = "Sneakers", ImageUrl = "images/image5.jpg", Price = 50 },
        };

        public Task<List<Product>> GetProductsAsync()
        {
            return Task.FromResult(products);
        }

        public Task<Product?> GetProductByIdAsync(int id)
        {
            return Task.FromResult(products.FirstOrDefault(p => p.Id == id));
        }
    }


}
