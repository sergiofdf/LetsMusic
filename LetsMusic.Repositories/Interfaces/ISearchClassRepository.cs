namespace LetsMusic.Repositories.Interfaces
{
    public interface ISearchClassRepository
    {
        public void ListAllData();
        public void GetDataById(int id);
        public void GetDataByYear(int year);
        public void ExecuteQuerySearch(string getSqlCommand);
    }
}
