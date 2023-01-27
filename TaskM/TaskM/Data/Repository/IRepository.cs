namespace TaskM.Data.Repository
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
        T GetById(Guid id);
        void Add(T entity);
        void Update(Guid id, T entity);
        void Delete(T entity);
        void Save();
    }
}
