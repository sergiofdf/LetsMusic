namespace LetsMusic.Services
{
    public interface ISearchServices
    {
        public void SearchById(int id, string searchObject);
        public void SearchByName(string name, string searchObject);
        public void ListAllData(string searchObject);
        public void SearchByYear(int year, string searchObject);
    }
}
