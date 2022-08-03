using LetsMusic.Repositories.Interfaces;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace LetsMusic.Repositories.Base
{
    public class BaseRepository : IBaseRepository
    {
        public bool Save(string saveSqlCommand)
        {
            try
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
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable Get(string getSqlCommand)
        {
            try
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
            catch (Exception)
            {
                return null;
            }
        }
        public void Update(string updateSqlCommand)
        {

        }
    }
}

