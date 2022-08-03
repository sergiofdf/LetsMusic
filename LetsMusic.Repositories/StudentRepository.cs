using LetsMusic.Domain;
using LetsMusic.Repositories.Interfaces;
using System.Data;

namespace LetsMusic.Repositories
{
    public class StudentRepository : ISearchRepository<Student>, IRegistrationRepository<Student>
    {
        private readonly IBaseRepository _baseRepository;
        public StudentRepository(IBaseRepository baseRepository)
        {
            _baseRepository = baseRepository;
        }
        public DataTable ListAllData()
        {
            string getSqlCommand = $"SELECT * FROM aluno";
            return ExecuteQuerySearch(getSqlCommand);
        }
        public DataTable GetDataById(int id)
        {
            string getSqlCommand = $"SELECT * FROM aluno WHERE Matr_Aluno = {id};";
            return ExecuteQuerySearch(getSqlCommand);
        }
        public DataTable GetDataByName(string name)
        {
            string getSqlCommand = $"SELECT * FROM aluno WHERE UPPER(Nome_Aluno) LIKE UPPER('%{name}%');";
            return ExecuteQuerySearch(getSqlCommand);
        }
        public DataTable ExecuteQuerySearch(string getSqlCommand)
        {
            DataTable students = _baseRepository.Get(getSqlCommand);
            return students;
        }
        public bool Save(Student student)
        {
            string saveSqlCommand = $"INSERT INTO aluno VALUES('{student.Name}', '{student.Phone}','{student.Email}'); ";
            return _baseRepository.Save(saveSqlCommand);
        }
    }
}
