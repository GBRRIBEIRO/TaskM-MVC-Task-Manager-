
using Microsoft.EntityFrameworkCore;

namespace TaskM.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        DatabaseContext _dbContext { get; set; }
        DbSet<T> _dbSet { get; set; }

        public Repository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }
        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }
        public T GetById(Guid id)
        {
            return _dbSet.Find(id);
        }
        public void Add(T obj)
        {
            _dbSet.Add(obj);
        }
        public void Delete(T obj)
        {
            _dbSet.Remove(obj);
        }

        public void Update(Guid id, T obj)
        {
            var _obj = _dbSet.Find(id);
            _obj = obj;
            _dbSet.Update(_obj);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}