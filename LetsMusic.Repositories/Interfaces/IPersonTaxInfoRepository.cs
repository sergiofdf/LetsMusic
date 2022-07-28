using LetsMusic.Domain;

namespace LetsMusic.Repositories.Interfaces
{
    public interface IPersonTaxInfoRepository
    {
        public void SavePerson(Person person);
        public Person GetPersonByCpf(string cpf);
        public List<Person> ListAllRegister();
    }
}
