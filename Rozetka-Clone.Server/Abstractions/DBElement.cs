namespace Rozetka_Clone.Server.Abstractions
{
    public abstract class DBElement
    {
        public Guid id {  get; set; }

        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public DateTime? deletedAt {  get; set; }
    }
}
