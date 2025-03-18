using Microsoft.AspNetCore.Mvc;
using ProductCatalogAPI.Dtos;
using ProductCatalogAPI.Handlers.Category;

namespace ProductCatalogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryHandler _categoryHandler;

        public CategoryController(ICategoryHandler categoryHandler)
        {
            _categoryHandler = categoryHandler;
        }

        [HttpGet]
        public async Task<CategoriesResponse> GetCategories()
        {
            try
            {
                return await _categoryHandler.GetCategories();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpPost]
        public async Task<CategoryDto> CreateCategory(CategoryDto categoryDto)
        {
            try
            {
                return await _categoryHandler.Createcategory(categoryDto);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
