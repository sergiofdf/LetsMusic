namespace LetsMusic.Repositories.Interfaces
{
    public interface IRegistrationRepository<T> where T : class
    {
        public void Save(T entity);
    }
}
