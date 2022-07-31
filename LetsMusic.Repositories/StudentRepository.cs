﻿using LetsMusic.Domain;
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
        public void ListAllData()
        {
            string getSqlCommand = $"SELECT * FROM aluno";
            ExecuteQuerySearch(getSqlCommand);
        }
        public void GetDataById(int id)
        {
            string getSqlCommand = $"SELECT * FROM aluno WHERE Matr_Aluno = {id};";
            ExecuteQuerySearch(getSqlCommand);
        }
        public void GetDataByName(string name)
        {
            string getSqlCommand = $"SELECT * FROM aluno WHERE UPPER(Nome_Aluno) LIKE UPPER('%{name}%');";
            ExecuteQuerySearch(getSqlCommand);
        }
        public void ExecuteQuerySearch(string getSqlCommand)
        {
            DataTable students = _baseRepository.Get(getSqlCommand);
            students.Print();
        }
        public void Save(Student student)
        {
            string saveSqlCommand = $"INSERT INTO aluno VALUES('{student.Name}', '{student.Phone}','{student.Email}'); ";
            _baseRepository.Save(saveSqlCommand);
        }
    }
}
