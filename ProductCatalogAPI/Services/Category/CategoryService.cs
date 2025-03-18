using Microsoft.EntityFrameworkCore;
using ProductCatalogAPI.Entities;

namespace ProductCatalogAPI.Services.Category
{
    public class CategoryService(ProductCatalogContext _context) : ICategoryService
    {
        public async Task<List<Entities.Category>> GetCategories()
        {
            return await _context.Categories.ToListAsync();
        }
        
        public async Task<Entities.Category> CreateCategory(Entities.Category category)
        {
            using var transaction = await _context.Database.BeginTransactionAsync();

            try
            {
                _context.Categories.Add(category);
                await _context.SaveChangesAsync();
                await transaction.CommitAsync();
                return category;
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                throw;
            }
        }
    }
}
