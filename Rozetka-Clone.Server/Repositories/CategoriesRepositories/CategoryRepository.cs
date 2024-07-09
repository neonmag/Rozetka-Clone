using Microsoft.EntityFrameworkCore;
using Rozetka_Clone.Server.Data;
using Rozetka_Clone.Server.Entity.Categories;
using Rozetka_Clone.Server.Repositories.IRepositories;

namespace Rozetka_Clone.Server.Repositories.CategoriesRepositories
{
    public class CategoryRepository : IRepository<Categories>, ICategoriesRepository
    {
        private readonly DataContext _dataContext;

        public CategoryRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<Categories>> GetAll()
        {
            var response = await _dataContext.dbCategories
                .Where(c => c.deletedAt == null)
                .Select(c => new Categories(c.id, c.name, c.image, c.createdAt, c.updatedAt)).ToListAsync();

            return response;
        }

        public async Task<List<Categories>> GetAllByGuidList(List<Guid> guidList)
        {
            List<Categories> response = new List<Categories>();

            foreach (var id in guidList)
            { 
                var result = await _dataContext.dbCategories
                    .Where(c => c.deletedAt == null)
                    .Where(c => c.id == id)
                    .Select(c => new Categories(
                        c.id,
                        c.name,
                        c.image,
                        c.createdAt,
                        c.updatedAt
                        )).FirstOrDefaultAsync();


                if (result != null)
                {
                    response.Add(result);
                }
            }

            return response;
        }
    }
}
