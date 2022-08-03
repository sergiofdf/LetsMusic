using LetsMusic.Domain;
using LetsMusic.Repositories.Interfaces;
using System.Data;

namespace LetsMusic.Repositories
{
    public class TeacherRepository : ISearchRepository<Teacher>, IRegistrationRepository<Teacher>
    {
        private readonly IBaseRepository _baseRepository;
        public TeacherRepository(IBaseRepository baseRepository)
        {
            _baseRepository = baseRepository;
        }
        public DataTable GetDataById(int id)
        {
            string getSqlCommand = $"SELECT * FROM professor WHERE Matr_Prof = {id};";
            return ExecuteQuerySearch(getSqlCommand);
        }
        public DataTable GetDataByName(string name)
        {
            string getSqlCommand = $"SELECT * FROM professor WHERE UPPER(Nome_Prof) LIKE UPPER('%{name}%');";
            return ExecuteQuerySearch(getSqlCommand);
        }
        public DataTable ListAllData()
        {
            string getSqlCommand = $"SELECT * FROM professor";
            return ExecuteQuerySearch(getSqlCommand);
        }
        public DataTable ExecuteQuerySearch(string getSqlCommand)
        {
            DataTable teachers = _baseRepository.Get(getSqlCommand);
            return teachers;
        }
        public bool Save(Teacher teacher)
        {
            string saveSqlCommand = $"INSERT INTO professor VALUES('{teacher.Name}',{teacher.Salary},'{teacher.Phone}','{teacher.Email}'); ";
            return _baseRepository.Save(saveSqlCommand);
        }
    }
}
