using Rozetka_Clone.Server.Abstractions.Categories;

namespace Rozetka_Clone.Server.Entity.Categories
{
    public class Categories : CategoryElement
    {
        public Categories(Guid id, String name, String image, DateTime createdAt, DateTime updatedAt)
        {
            this.id = id;
            this.name = name;
            this.image = image;
            this.createdAt = createdAt;
            this.updatedAt = updatedAt;
        }
    }
}
