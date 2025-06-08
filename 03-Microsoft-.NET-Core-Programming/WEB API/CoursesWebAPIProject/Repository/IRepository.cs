namespace WebAPIProject.Repository
{
    public interface IRepository<T>
    {
        List<T> Get();
        T? GetById(int id);
        void Post(T entity);
        void Put(int id, T entity);
        void DeleteCourse(int id);
        T? CourseByName(string name);
        void Save();

    }
}
