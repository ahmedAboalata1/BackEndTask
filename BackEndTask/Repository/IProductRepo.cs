using BackEndTask.Models;

namespace BackEndTask.Repository
{
    public interface IProductRepo
    {
        List<Product> GetProducts();
        void CreateProduct(Product product);
        void DeleteProduct(int id);
    }
}
