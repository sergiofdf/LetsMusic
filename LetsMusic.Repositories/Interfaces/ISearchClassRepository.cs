using System.Data;

namespace LetsMusic.Repositories.Interfaces
{
    public interface ISearchClassRepository
    {
        public DataTable ListAllData();
        public DataTable GetDataById(int id);
        public DataTable GetDataByYear(int year);
        public DataTable ExecuteQuerySearch(string getSqlCommand);
    }
}
