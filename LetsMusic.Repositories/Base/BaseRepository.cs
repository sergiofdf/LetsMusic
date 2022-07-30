using LetsMusic.Repositories.Interfaces;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace LetsMusic.Repositories.Base
{
    public class BaseRepository : IBaseRepository
    {
        public BaseRepository()
        {

        }
        public void Save(string saveSqlCommand)
        {
            string conString = ConfigurationManager.ConnectionStrings["LetsMusic"].ConnectionString;

            using (SqlConnection openCon = new SqlConnection(conString))
            {
                using (SqlCommand querySaveStaff = new SqlCommand(saveSqlCommand))
                {
                    querySaveStaff.Connection = openCon;
                    openCon.Open();
                    querySaveStaff.ExecuteNonQuery();
                }
            }
        }

        public DataTable Get(string getSqlCommand)
        {
            string conString = ConfigurationManager.ConnectionStrings["LetsMusic"].ConnectionString;

            using (SqlConnection openCon = new SqlConnection(conString))
            {
                SqlDataAdapter sqlda = new SqlDataAdapter(getSqlCommand, openCon);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);

                return dtbl;
            }
        }
        public void Update(string updateSqlCommand)
        {

        }
    }
}

