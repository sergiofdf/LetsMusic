using LetsMusic.Domain;
using LetsMusic.Repositories.Interfaces;

namespace LetsMusic.Services
{
    public class SearchServices : ISearchServices
    {
        private readonly ISearchRepository<Student> _studentRepository;
        private readonly ISearchRepository<Teacher> _teacherRepository;
        private readonly ISearchRepository<Course> _courseRepository;
        private readonly ISearchClassRepository _classRepository;

        public SearchServices(ISearchRepository<Student> studentRepository,
            ISearchRepository<Teacher> teacherRepository,
            ISearchRepository<Course> courseRepository,
            ISearchClassRepository classRepository
            )
        {
            _studentRepository = studentRepository;
            _teacherRepository = teacherRepository;
            _courseRepository = courseRepository;
            _classRepository = classRepository;
        }

        public void SearchById(int id, string searchObject)
        {
            if (searchObject == "student")
            {
                _studentRepository.GetDataById(id);
            }
            else if (searchObject == "teacher")
            {
                _teacherRepository.GetDataById(id);
            }
            else if (searchObject == "course")
            {
                _courseRepository.GetDataById(id);
            }
            else if (searchObject == "class")
            {
                _classRepository.GetDataById(id);
            }
        }

        public void SearchByName(string name, string searchObject)
        {
            if (searchObject == "student")
            {
                _studentRepository.GetDataByName(name);
            }
            else if (searchObject == "teacher")
            {
                _teacherRepository.GetDataByName(name);
            }
            else if (searchObject == "course")
            {
                _courseRepository.GetDataByName(name);
            }
        }

        public void ListAllData(string searchObject)
        {
            if (searchObject == "student")
            {
                _studentRepository.ListAllData();
            }
            else if (searchObject == "teacher")
            {
                _teacherRepository.ListAllData();
            }
            else if (searchObject == "course")
            {
                _courseRepository.ListAllData();
            }
            else if (searchObject == "class")
            {
                _classRepository.ListAllData();
            }
        }
        public void SearchByYear(int year, string searchObject)
        {
            if (searchObject == "class")
            {
                _classRepository.GetDataByYear(year);
            }
        }
    }
}
