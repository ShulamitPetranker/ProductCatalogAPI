using ProductCatalogAPI.Dtos;

namespace ProductCatalogAPI.Handlers.Category
{
    public interface ICategoryHandler
    {
        public Task<CategoriesResponse> GetCategories();
        public Task<CategoryDto> Createcategory(CategoryDto category);
    }
}
