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
        public DataTable ListAllData()
        {
            string getSqlCommand = $"SELECT Cod_turma, Ano, Matr_Prof, Cod_curso, CASE WHEN Periodo = 'M' THEN 'Matutino' WHEN Periodo = 'V' THEN 'Vespertino' ELSE 'Noturno' END AS 'Periodo' FROM turma";
            return ExecuteQuerySearch(getSqlCommand);
        }
        public DataTable GetDataById(int id)
        {
            string getSqlCommand = $"SELECT Cod_turma, Ano, Matr_Prof, Cod_curso, CASE WHEN Periodo = 'M' THEN 'Matutino' WHEN Periodo = 'V' THEN 'Vespertino' ELSE 'Noturno' END AS 'Periodo' FROM turma WHERE Cod_turma = {id};";
            return ExecuteQuerySearch(getSqlCommand);
        }
        public DataTable GetDataByYear(int year)
        {
            string getSqlCommand = $"SELECT Cod_turma, Ano, Matr_Prof, Cod_curso, CASE WHEN Periodo = 'M' THEN 'Matutino' WHEN Periodo = 'V' THEN 'Vespertino' ELSE 'Noturno' END AS 'Periodo' FROM turma WHERE Ano = {year};";
            return ExecuteQuerySearch(getSqlCommand);
        }
        public DataTable ExecuteQuerySearch(string getSqlCommand)
        {
            DataTable students = _baseRepository.Get(getSqlCommand);
            return students;
        }
    }
}
