namespace ProductCatalogAPI.Services.Category
{
    public interface ICategoryService
    {
        public Task<List<Entities.Category>> GetCategories();
        public Task<Entities.Category> CreateCategory(Entities.Category category);
    }
}
