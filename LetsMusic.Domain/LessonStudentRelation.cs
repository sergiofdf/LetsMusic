namespace LetsMusic.Domain
{
    public class LessonStudentRelation
    {
        public int LessonStudentId { get; set; }
        public int LessonId { get; set; }
        public int StudentId { get; set; }
        public bool Attendance { get; set; }
    }
}
