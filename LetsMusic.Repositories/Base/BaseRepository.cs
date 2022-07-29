using LetsMusic.Repositories.Interfaces;
using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;

namespace LetsMusic.Repositories.Base
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        public BaseRepository()
        {
        }
        public void Save(IEnumerable<T> values)
        {
            SqlConnection sqlCon = new SqlConnection(@"Server=vps40251.publiccloud.com.br;Database=LetsMusic;User Id=sergio.dias;Password=Abc123546!;");
            SqlDataAdapter sqlda = new SqlDataAdapter("SELECT * FROM Aluno", sqlCon);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            foreach (DataRow row in dtbl.Rows)
            {
                Console.WriteLine(row["Nome_aluno"]);
            }
        }

        public IEnumerable<T> Get()
        {
            IEnumerable<T> response = default;
            var name = $"{typeof(T).Name}.txt";

            if (File.Exists(name))
            {
                var fileStr = File.ReadAllText(name);

                if (!string.IsNullOrWhiteSpace(fileStr))
                    response = JsonConvert.DeserializeObject<IEnumerable<T>>(fileStr);
            }

            return response;
        }
    }
}

