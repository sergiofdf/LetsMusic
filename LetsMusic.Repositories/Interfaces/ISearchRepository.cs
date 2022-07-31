namespace LetsMusic.Repositories.Interfaces
{
    public interface ISearchRepository<T> where T : class
    {
        public void ListAllData();
        public void GetDataById(int id);
        public void GetDataByName(string name);
        public void ExecuteQuerySearch(string getSqlCommand);
    }
}
