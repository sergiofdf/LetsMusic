using LetsMusic.Domain;
using LetsMusic.Repositories.Interfaces;
using System.Data;

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

        public DataTable SearchById(int id, string searchObject)
        {
            if (searchObject == "student")
            {
                return _studentRepository.GetDataById(id);
            }
            else if (searchObject == "teacher")
            {
                return _teacherRepository.GetDataById(id);
            }
            else if (searchObject == "course")
            {
                return _courseRepository.GetDataById(id);
            }
            else
            {
                return _classRepository.GetDataById(id);
            }
        }

        public DataTable SearchByName(string name, string searchObject)
        {
            if (searchObject == "student")
            {
                return _studentRepository.GetDataByName(name);
            }
            else if (searchObject == "teacher")
            {
                return _teacherRepository.GetDataByName(name);
            }
            else
            {
                return _courseRepository.GetDataByName(name);
            }
        }

        public DataTable ListAllData(string searchObject)
        {
            if (searchObject == "student")
            {
                return _studentRepository.ListAllData();
            }
            else if (searchObject == "teacher")
            {
                return _teacherRepository.ListAllData();
            }
            else if (searchObject == "course")
            {
                return _courseRepository.ListAllData();
            }
            else
            {
                return _classRepository.ListAllData();
            }
        }
        public DataTable SearchByYear(int year)
        {
            return _classRepository.GetDataByYear(year);
        }
    }
}
