using LetsMusic.Domain;
using LetsMusic.Repositories.Interfaces;
using System.Data;

namespace LetsMusic.Repositories
{
    public class CourseRepository : ISearchRepository<Course>, IRegistrationRepository<Course>
    {
        private readonly IBaseRepository _baseRepository;
        public CourseRepository(IBaseRepository baseRepository)
        {
            _baseRepository = baseRepository;
        }
        public DataTable ListAllData()
        {
            string getSqlCommand = $"SELECT * FROM curso";
            return ExecuteQuerySearch(getSqlCommand);
        }
        public DataTable GetDataById(int id)
        {
            string getSqlCommand = $"SELECT * from curso WHERE Cod_curso = {id};";
            return ExecuteQuerySearch(getSqlCommand);
        }
        public DataTable GetDataByName(string name)
        {
            string getSqlCommand = $"SELECT * from curso WHERE UPPER(Nome_Curso) LIKE UPPER('%{name}%');";
            return ExecuteQuerySearch(getSqlCommand);
        }
        public DataTable ExecuteQuerySearch(string getSqlCommand)
        {
            DataTable students = _baseRepository.Get(getSqlCommand);
            return students;
        }
        public bool Save(Course course)
        {
            string saveSqlCommand = $"INSERT INTO curso VALUES('{course.Name}', '{course.Workload}','{course.Vacancies}'); ";
            return _baseRepository.Save(saveSqlCommand);
        }
    }
}
