namespace Ocelot.Product.Repos
{
    public static class ProductRepo
    {
        public static List<Model.Product> _products = new List<Model.Product>
        {
            new Model.Product { id = 1, name = "Laptop", price = 1500.00m, Quantity = 10 },
            new Model.Product { id = 2, name = "Smartphone", price = 800.00m, Quantity = 25 },
            new Model.Product { id = 3, name = "Headphones", price = 120.00m, Quantity = 50 }
        };
        // ✅ Get all products
        public static List<Model.Product> GetAll() => _products;

        // ✅ Get product by ID
        public static Model.Product? GetById(int id) =>
            _products.FirstOrDefault(p => p.id == id);
    }
}
