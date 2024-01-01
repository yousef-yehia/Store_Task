using Store_Task.Models;

namespace Store_Task.Interfaces
{
    public interface ICategoryRepository : IRepository<Category>
    {
        public Task<Category> UpdateAsync(Category category);

    }
}
