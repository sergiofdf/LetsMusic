using LetsMusic.Domain;
using LetsMusic.Repositories.Interfaces;
using System.Data.SqlClient;

namespace LetsMusic.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        public TeacherRepository()
        {

        }
        public void SaveTeacher(Teacher teacher)
        {
            string conString = @"Server=vps40251.publiccloud.com.br;Database=LetsMusic;User Id=sergio.dias;Password=Abc123546!;";


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
