using Microsoft.EntityFrameworkCore;
using Rozetka_Clone.Server.Data;
using Rozetka_Clone.Server.Entity.Categories;
using Rozetka_Clone.Server.Repositories.IRepositories;

namespace Rozetka_Clone.Server.Repositories.CategoriesRepositories
{
    public class CategoriesUnionRepository : IRepository<CategoryUnion>, IUnionCategoriesRepository
    {
        private readonly DataContext _dataContext;

        public CategoriesUnionRepository(DataContext context)
        {
            _dataContext = context;
        }

        public async Task<List<CategoryUnion>> GetAll()
        {
            var response = await _dataContext.dbCategoriesUnion
                .Where(c => c.deletedAt == null)
                .Select(c => new CategoryUnion(
                    c.id,
                    c.categoryId,
                    c.subCategoryId,
                    c.createdAt,
                    c.updatedAt
                    )).ToListAsync();

            return response;
        }

        public async Task<List<CategoryUnion>> GetAllByGuidList(List<Guid> guidList)
        {
            List<CategoryUnion> response = new List<CategoryUnion>();

            foreach (var id in guidList)
            {
                var result = await _dataContext.dbCategoriesUnion
                    .Where(c => c.deletedAt == null)
                    .Where(c => c.id == id)
                    .Select(c => new CategoryUnion(
                        c.id,
                        c.categoryId,
                        c.subCategoryId,
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
