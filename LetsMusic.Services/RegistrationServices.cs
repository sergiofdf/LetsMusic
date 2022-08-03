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
            return _teacherRepository.Save(teacher);
        }
        public bool StudentRegistration(Student student)
        {
            return _studentRepository.Save(student);

        }
        public bool CourseRegistration(Course course)
        {
            return _courseRepository.Save(course);
        }
    }
}
