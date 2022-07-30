namespace LetsMusic.Services
{
    public interface ISearchServices
    {
        public void SearchPersonById(int id);
        public void SearchPersonByName(string name);
        public void ListAllPerson();
    }
}
