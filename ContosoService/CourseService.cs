using ContosoData;
using ContosoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoService
{
    public class CourseService
    {
        public List<Course> GetAllCourses()
        {
            CourseRepository repository = new CourseRepository();
            return repository.GetAll();
        }

        public void Create(Course course)
        {
            CourseRepository repository = new CourseRepository();
            repository.CreateNew(course);
        }

        public Course GetById(int Id)
        {
            CourseRepository repository = new CourseRepository();
            return repository.GetById(Id);
        }


        public void Update(Course course)
        {
            CourseRepository repository = new CourseRepository();
            repository.Update(course);
        }
    }
}
