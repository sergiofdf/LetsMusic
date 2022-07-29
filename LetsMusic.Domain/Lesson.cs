namespace LetsMusic.Domain
{
    public class Lesson
    {
        public int LessonId { get; set; }
        public TimeOnly Hour { get; set; }
        public DateOnly Date { get; set; }
        public int TeacherRegistration { get; set; }
    }
}
