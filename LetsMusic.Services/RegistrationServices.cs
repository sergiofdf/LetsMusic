using LetsMusic.Domain;
using LetsMusic.Repositories.Interfaces;

namespace LetsMusic.Services
{
    public class RegistrationServices : IRegistrationServices
    {
        private readonly IRegistrationRepository<Teacher> _teacherRepository;
        private readonly IRegistrationRepository<Student> _studentRepository;
        private readonly IRegistrationRepository<Course> _courseRepository;
        public RegistrationServices(IRegistrationRepository<Teacher> teacherRepository
            , IRegistrationRepository<Student> studentRepository
            , IRegistrationRepository<Course> courseRepository
            )
        {
            _teacherRepository = teacherRepository;
            _studentRepository = studentRepository;
            _courseRepository = courseRepository;
        }
        public bool TeacherRegistration(Teacher teacher)
        {
            _teacherRepository.Save(teacher);
            return true;
        }
        public bool StudentRegistration(Student student)
        {
            _studentRepository.Save(student);
            return true;
        }
        public bool CourseRegistration(Course course)
        {
            _courseRepository.Save(course);
            return true;
        }
    }
}
