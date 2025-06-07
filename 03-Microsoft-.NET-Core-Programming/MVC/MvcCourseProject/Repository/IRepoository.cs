namespace MvcCourseProject.Repository
{
    public interface IRepoository<T>
    {
        List<T> GetAll();
        T? GetById(int id);
        void Add(T obj);

        void Update(T obj);

        void Delete(int id);

        void Save();
    }
}
