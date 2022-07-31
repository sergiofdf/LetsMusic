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
        public void GetDataById(int id)
        {
            string getSqlCommand = $"SELECT * FROM professor WHERE Matr_Prof = {id};";
            ExecuteQuerySearch(getSqlCommand);
        }
        public void GetDataByName(string name)
        {
            string getSqlCommand = $"SELECT * FROM professor WHERE UPPER(Nome_Prof) LIKE UPPER('%{name}%');";
            ExecuteQuerySearch(getSqlCommand);
        }
        public void ListAllData()
        {
            string getSqlCommand = $"SELECT * FROM professor";
            ExecuteQuerySearch(getSqlCommand);
        }
        public void ExecuteQuerySearch(string getSqlCommand)
        {
            DataTable teachers = _baseRepository.Get(getSqlCommand);
            teachers.Print();
        }
        public void Save(Teacher teacher)
        {
            string saveSqlCommand = $"INSERT INTO professor VALUES('{teacher.Name}',{teacher.Salary},'{teacher.Phone}','{teacher.Email}'); ";
            _baseRepository.Save(saveSqlCommand);
        }
    }
}
