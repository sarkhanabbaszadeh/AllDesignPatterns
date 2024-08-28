using WebApp.Strategy.Models;

namespace WebApp.Strategy.Repositories
{
    public interface IProductRepository
    {
        Task<Product> GetbyId(string id);

        Task<List<Product>> GetAllByUserId(string userId);

        Task Update(Product product);

        Task Delete(Product product);
    }
}
