namespace LetsMusic.Repositories.Interfaces
{
    public interface IRegistrationRepository<T> where T : class
    {
        public bool Save(T entity);
    }
}
