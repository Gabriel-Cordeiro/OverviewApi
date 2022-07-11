using Overview.Core.Entities;


namespace Overview.Core.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetById(int id);

        Task<IEnumerable<T>> GetAll();

        Task<bool> Add(BaseEntity newEntity);

        Task<bool> Update(BaseEntity entity);

        Task<bool> Remove(int id);
    }
}
