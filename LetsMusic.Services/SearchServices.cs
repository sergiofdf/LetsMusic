using LetsMusic.Repositories.Interfaces;

namespace LetsMusic.Services
{
    public class SearchServices : ISearchServices
    {
        private readonly IStudentRepository _studentRepository;

        public SearchServices(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void SearchPersonById(int id)
        {
            throw new NotImplementedException();
        }

        public void SearchPersonByName(string name)
        {
            throw new NotImplementedException();
        }

        public void ListAllPerson()
        {
            _studentRepository.ListAllStudents();
        }
    }
}
