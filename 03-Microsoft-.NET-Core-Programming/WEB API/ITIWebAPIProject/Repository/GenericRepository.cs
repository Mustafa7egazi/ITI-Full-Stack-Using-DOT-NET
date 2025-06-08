using ITIWebAPIProjectDay02.Data;

namespace ITIWebAPIProject.Repository
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        protected ITIContext db;
        public GenericRepository(ITIContext _db)
        {
            db = _db;
        }

        public List<TEntity> GetAll()
        {
            return db.Set<TEntity>().ToList();
        }

        public TEntity? GetById(int id)
        {
            return db.Set<TEntity>().Find(id);
        }

        public void Add(TEntity entity)
        {
            db.Set<TEntity>().Add(entity);
        }

        public void Edit(TEntity e)
        {
            db.Entry(e).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public void Delete(TEntity entity)
        {
          db.Set<TEntity>().Remove(entity);
        }

    }
}
