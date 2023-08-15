using BackEndTask.Models;

namespace BackEndTask.Repository
{
    public class ProductRepo:IProductRepo
    {
        private readonly Context context;

        public ProductRepo(Context context)
        {
            this.context = context;
        }
        public List<Product> GetProducts()
        {
            List<Product> products = context.Products.ToList();
            return products;
        }

        public void CreateProduct(Product product)
        {
            context.Products.Add(product);  
            context.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            Product product = context.Products.FirstOrDefault(p => p.Id == id);
            context.Products.Remove(product);
            context.SaveChanges();
        }

    }
}
