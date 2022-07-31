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
        public void ListAllData()
        {
            string getSqlCommand = $"SELECT * FROM curso";
            ExecuteQuerySearch(getSqlCommand);
        }
        public void GetDataById(int id)
        {
            string getSqlCommand = $"SELECT * from curso WHERE Cod_curso = {id};";
            ExecuteQuerySearch(getSqlCommand);
        }
        public void GetDataByName(string name)
        {
            string getSqlCommand = $"SELECT * from curso WHERE UPPER(Nome_Curso) LIKE UPPER('%{name}%');";
            ExecuteQuerySearch(getSqlCommand);
        }
        public void ExecuteQuerySearch(string getSqlCommand)
        {
            DataTable students = _baseRepository.Get(getSqlCommand);
            students.Print();
        }
        public void Save(Course course)
        {
            string saveSqlCommand = $"INSERT INTO curso VALUES('{course.Name}', '{course.Workload}','{course.Vacancies}'); ";
            _baseRepository.Save(saveSqlCommand);
        }
    }
}
