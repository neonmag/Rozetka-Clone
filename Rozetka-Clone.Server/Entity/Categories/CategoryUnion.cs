using Rozetka_Clone.Server.Abstractions;

namespace Rozetka_Clone.Server.Entity.Categories
{
    public class CategoryUnion : DBElement
    {
        public Guid categoryId { get; set; }
        public Guid subCategoryId { get; set; }

        public CategoryUnion(Guid id, Guid categoryId, Guid subCategoryId, DateTime createdAt, DateTime updatedAt) 
        {
            this.id = id;
            this.categoryId = categoryId;
            this.subCategoryId = subCategoryId;
            this.createdAt = createdAt;
            this.updatedAt = updatedAt;
        }
    }
}
