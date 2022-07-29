using LetsMusic.Domain;
using LetsMusic.Repositories.Interfaces;

namespace LetsMusic.Services
{
    public class TeacherServices : ITeacherServices
    {
        private readonly ITeacherRepository _teacherRepository;
        public TeacherServices(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }
        public bool TeacherRegistration(Teacher teacher)
        {
            _teacherRepository.SaveTeacher(teacher);
            return true;
        }
    }
}
