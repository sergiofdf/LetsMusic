using LetsMusic.Domain;
using LetsMusic.Repositories.Interfaces;

namespace LetsMusic.Services
{
    public class RegistrationServices : IRegistrationServices
    {
        private readonly ITeacherRepository _teacherRepository;
        public RegistrationServices(ITeacherRepository teacherRepository)
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
