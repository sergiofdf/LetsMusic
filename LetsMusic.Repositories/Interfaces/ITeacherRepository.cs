using LetsMusic.Domain;

namespace LetsMusic.Repositories.Interfaces
{
    public interface ITeacherRepository
    {
        public void SaveTeacher(Teacher teacher);
        //public Person GetPersonByCpf(string cpf);
        //public List<Person> ListAllRegister();
    }
}
