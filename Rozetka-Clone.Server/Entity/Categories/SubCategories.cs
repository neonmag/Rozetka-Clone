using Rozetka_Clone.Server.Abstractions.Categories;

namespace Rozetka_Clone.Server.Entity.Categories
{
    public class SubCategories : CategoryElement
    {
        public SubCategories(Guid id, String name, DateTime createdAt, DateTime updatedAt)
        {
            this.id = id;
            this.name = name;
            this.createdAt = createdAt;
            this.updatedAt = updatedAt;
        }
    }
}
