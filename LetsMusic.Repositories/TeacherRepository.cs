using LetsMusic.Domain;
using LetsMusic.Repositories.Interfaces;

namespace LetsMusic.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        public TeacherRepository()
        {

        }
        public void SaveTeacher(Teacher teacher)
        {
            string saveStaff = $"INSERT INTO professor VALUES('{teacher.Name}',{teacher.Salary},'{teacher.Phone}','{teacher.Email}'); ";
        }

        public void GetTeacher(Teacher teacher)
        {
            string getStaff = $"SELECT * FROM professor";
        }
    }
}
