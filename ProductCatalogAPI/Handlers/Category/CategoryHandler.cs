using AutoMapper;
using ProductCatalogAPI.Dtos;
using ProductCatalogAPI.Services.Category;

namespace ProductCatalogAPI.Handlers.Category
{
    public class CategoryHandler(ICategoryService _categoryService,
        IMapper _mapper) : ICategoryHandler
    {
        public async Task<CategoriesResponse> GetCategories()
        {
            var categories = await _categoryService.GetCategories();

            return new CategoriesResponse(Categories: categories == null || categories.Count <= 0
                ? null
                : _mapper.Map<List<Entities.Category>, List<CategoryDto>>(categories));
        }

        public async Task<CategoryDto> Createcategory(CategoryDto category)
        {
            if(category == null)
            {
                return new CategoryDto(-1, "", null);
            }
            else
            {
                var newCategory = await _categoryService.CreateCategory(_mapper.Map<Entities.Category>(category));
                return _mapper.Map<CategoryDto>(newCategory);
            }
        }
    }
}
