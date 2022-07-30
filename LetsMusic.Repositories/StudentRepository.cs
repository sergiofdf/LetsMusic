using LetsMusic.Repositories.Interfaces;
using System.Data;

namespace LetsMusic.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly IBaseRepository _baseRepository;
        public StudentRepository(IBaseRepository baseRepository)
        {
            _baseRepository = baseRepository;
        }
        public void ListAllStudents()
        {
            string getStaff = $"SELECT * FROM aluno";
            DataTable students = _baseRepository.Get(getStaff);

            foreach (DataRow row in students.Rows)
            {
                Console.WriteLine(row["Nome_aluno"]);
            }

        }
    }
}
