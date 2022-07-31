using LetsMusic.Domain;

namespace LetsMusic.Services
{
    public interface IRegistrationServices
    {
        public bool TeacherRegistration(Teacher teacher);
        public bool StudentRegistration(Student student);
        public bool CourseRegistration(Course course);
    }
}
