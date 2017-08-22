using ContosoData;
using ContosoModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoData
{
    public class DepartmentRepository : IRepository<Department>
    {
        public void CreateNew(Department dept)
        {
            using (var Db = new ContosoDBContext())
            {
                Db.Department.Add(dept);
                Db.SaveChanges();
            }
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Department> GetAll()
        {
            using (var Db = new ContosoDBContext())
            {
                var departments = Db.Department.ToList();
                return departments;
            }
        }

        public Department GetById(int id)
        {
            using (var Db = new ContosoDBContext())
            {
                var department = Db.Department.Where(d => d.Id == id).FirstOrDefault();
                return department;
            }
        }

        public void Update(Department dept)
        {
            using (var Db = new ContosoDBContext())
            {
                Db.Department.Attach(dept);
                Db.Entry(dept).State = EntityState.Modified;
                Db.SaveChanges();
            }
        }
    }
}
