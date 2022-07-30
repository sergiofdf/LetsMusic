using System.Data;

namespace LetsMusic.Repositories.Interfaces
{
    public interface IBaseRepository
    {
        public void Save(string saveSqlCommand);
        public DataTable Get(string getSqlCommand);
        public void Update(string updateSqlCommand);
    }
}

