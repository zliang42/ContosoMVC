using ContosoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoData
{
    public class CourseRepository : IRepository<Course>
    {
        public void CreateNew(Course obj)
        {
            using (var Db = new ContosoDBContext())
            {
                Db.Course.Add(obj);
                Db.SaveChanges();
            }
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetAll()
        {
            using (var Db = new ContosoDBContext())
            {
                var courses = Db.Course.ToList();
                return courses;
            }
        }

        public Course GetById(int id)
        {
            using (var Db = new ContosoDBContext())
            {
                var course = Db.Course.Where(c => c.Id == id).FirstOrDefault();
                return course;
            }
        }

        public void Update(Course obj)
        {
            using (var Db = new ContosoDBContext())
            {
                Db.Course.Attach(obj);
                Db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                Db.SaveChanges();
            }
        }
    }
}
