namespace Rozetka_Clone.Server.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAll();
        Task<List<T>> GetAllByGuidList(List<Guid> guidList);
    }
}
