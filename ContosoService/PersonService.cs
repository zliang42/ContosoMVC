using ContosoData;
using ContosoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoService
{
    public class PersonService
    {
        public List<Person> GetAllPeople()
        {
            PersonRepository repository = new PersonRepository();
            return repository.GetAll();
        }

        public void Create(Person person)
        {
            PersonRepository repository = new PersonRepository();
            repository.CreateNew(person);
        }

        public Person GetById(int Id)
        {
            PersonRepository repository = new PersonRepository();
            return repository.GetById(Id);
        }

        public void Update (Person person)
        {
            PersonRepository repository = new PersonRepository();
            repository.Update(person);
        }
    }
}
