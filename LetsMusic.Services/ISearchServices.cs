using System.Data;

namespace LetsMusic.Services
{
    public interface ISearchServices
    {
        public DataTable SearchById(int id, string searchObject);
        public DataTable SearchByName(string name, string searchObject);
        public DataTable ListAllData(string searchObject);
        public DataTable SearchByYear(int year);
    }
}
