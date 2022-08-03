using System.Data;

namespace LetsMusic.Repositories.Interfaces
{
    public interface ISearchRepository<T> where T : class
    {
        public DataTable ListAllData();
        public DataTable GetDataById(int id);
        public DataTable GetDataByName(string name);
        public DataTable ExecuteQuerySearch(string getSqlCommand);
    }
}
