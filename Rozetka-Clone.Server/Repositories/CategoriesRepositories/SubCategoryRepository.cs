using Microsoft.EntityFrameworkCore;
using Rozetka_Clone.Server.Data;
using Rozetka_Clone.Server.Entity.Categories;
using Rozetka_Clone.Server.Repositories.IRepositories;

namespace Rozetka_Clone.Server.Repositories.CategoriesRepositories
{
    public class SubCategoryRepository : IRepository<SubCategories>, ISubCategoryRepository
    {
        private readonly DataContext _dataContext;

        public SubCategoryRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<SubCategories>> GetAll()
        {
            var response = await _dataContext.dbSubCategories
                .Where(c => c.deletedAt == null)
                .Select(c => new SubCategories(
                    c.id,
                    c.name,
                    c.createdAt,
                    c.updatedAt
                    )).ToListAsync();

            return response;
        }

        public async Task<List<SubCategories>> GetAllByGuidList(List<Guid> guidList)
        {
            List<SubCategories> response = new List<SubCategories>();

            foreach (var id in guidList)
            {
                var result = await _dataContext.dbSubCategories
                    .Where(c => c.deletedAt == null)
                    .Where(c => c.id == id)
                    .Select(c => new SubCategories(
                        c.id,
                        c.name,
                        c.createdAt,
                        c.updatedAt
                        )).FirstOrDefaultAsync();

                if(result != null)
                {
                    response.Add(result);
                }
            }

            return response;
        }
    }
}
