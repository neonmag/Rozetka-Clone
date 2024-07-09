namespace Rozetka_Clone.Server.Abstractions.Categories
{
    public abstract class CategoryElement : DBElement
    {
        public String name { get; set; } = null!;

        public String? image { get; set; }
    }
}
