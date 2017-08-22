using ContosoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoData
{
    public class PersonRepository : IRepository<Person>
    {
        public void CreateNew(Person obj)
        {
            using (var Db = new ContosoDBContext())
            {
                Db.Person.Add(obj);
                Db.SaveChanges();
            }
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetAll()
        {
            using (var Db = new ContosoDBContext())
            {
                var people = Db.Person.ToList();
                return people;
            }
        }

        public Person GetById(int id)
        {
            using (var Db = new ContosoDBContext())
            {
                var person = Db.Person.Where(p => p.Id == id).FirstOrDefault();
                return person;
            }
        }

        public void Update(Person obj)
        {
            using (var Db = new ContosoDBContext())
            {
                Db.Person.Attach(obj);
                Db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                Db.SaveChanges();
            }
        }
    }
}
