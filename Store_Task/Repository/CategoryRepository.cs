using Store_Task.Data;
using Store_Task.Interfaces;
using Store_Task.Models;

namespace Store_Task.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public AppDbContext _appDbContext;
        public CategoryRepository(AppDbContext appDb, AppDbContext appDbContext) : base(appDb)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Category> UpdateAsync(Category category)
        {
            _appDbContext.Update(category);
            await _appDbContext.SaveChangesAsync();
            return category;
        }
    }
}
