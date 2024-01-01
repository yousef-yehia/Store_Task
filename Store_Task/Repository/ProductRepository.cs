using Store_Task.Data;
using Store_Task.Interfaces;
using Store_Task.Models;

namespace Store_Task.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly AppDbContext _appDbContext;
        public ProductRepository(AppDbContext appDb, AppDbContext appDbContext) : base(appDb)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Product> UpdateAsync(Product product)
        {
            _appDbContext.Update(product);
            await _appDbContext.SaveChangesAsync();
            return product;
        }
    }
}
