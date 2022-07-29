using System.Configuration;
using System.Data.SqlClient;
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
            string conString = ConfigurationManager.ConnectionStrings["LetsMusic"].ConnectionString;

            using (SqlConnection openCon = new SqlConnection(conString))
            {
                string saveStaff = $"INSERT INTO professor VALUES('{teacher.Name}',{teacher.Salary},'{teacher.Phone}','{teacher.Email}'); ";

                using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                {
                    querySaveStaff.Connection = openCon;

                    openCon.Open();

                    querySaveStaff.ExecuteNonQuery();
                }
            }
        }
    }
}
