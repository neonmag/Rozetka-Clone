using Microsoft.AspNetCore.Mvc;
using Rozetka_Clone.Server.Entity.Categories;
using Rozetka_Clone.Server.Repositories.IRepositories;

namespace Rozetka_Clone.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : Controller
    {
        private readonly ICategoriesRepository _categoriesRepository;
        private readonly IUnionCategoriesRepository _unionCategoriesRepository;
        private readonly ISubCategoryRepository _subCategoryRepository;

        public CategoriesController(ICategoriesRepository categoriesRepository, IUnionCategoriesRepository unionCategoriesRepository, ISubCategoryRepository subCategoryRepository)
        {
            _categoriesRepository = categoriesRepository;
            _unionCategoriesRepository = unionCategoriesRepository;
            _subCategoryRepository = subCategoryRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var unions = await _unionCategoriesRepository.GetAll();

            var categories = await _categoriesRepository.GetAll();

            var subcategories = await _subCategoryRepository.GetAll();

            var response = new
            {
                unions = unions,
                categories = categories,
                subcategories = subcategories
            };

            return Ok(response);
        }
    }
}
