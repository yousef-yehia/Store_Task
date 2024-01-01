using Store_Task.Models;

namespace Store_Task.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        public Task<Product> UpdateAsync(Product product);

    }
}
