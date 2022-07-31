using LetsMusic.Repositories.Interfaces;
using System.Data;

namespace LetsMusic.Repositories
{
    public class ClassRepository : ISearchClassRepository
    {
        private readonly IBaseRepository _baseRepository;
        public ClassRepository(IBaseRepository baseRepository)
        {
            _baseRepository = baseRepository;
        }
        public void ListAllData()
        {
            string getSqlCommand = $"SELECT * FROM turma";
            ExecuteQuerySearch(getSqlCommand);
        }
        public void GetDataById(int id)
        {
            string getSqlCommand = $"SELECT * FROM turma WHERE Cod_turma = {id};";
            ExecuteQuerySearch(getSqlCommand);
        }
        public void GetDataByYear(int year)
        {
            string getSqlCommand = $"SELECT * FROM turma WHERE Ano = {year};";
            ExecuteQuerySearch(getSqlCommand);
        }
        public void ExecuteQuerySearch(string getSqlCommand)
        {
            DataTable students = _baseRepository.Get(getSqlCommand);
            students.Print();
        }
    }
}
