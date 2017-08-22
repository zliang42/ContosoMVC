using ContosoData;
using ContosoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoService
{
    public class DepartmentService
    {
        public List<Department> GetAllDepartment()
        {
            DepartmentRepository repository = new DepartmentRepository();
            var Department = repository.GetAll();
            return Department;
        }

        public void Create(Department departmennt)
        {
            DepartmentRepository repository = new DepartmentRepository();
            repository.CreateNew(departmennt);
        }

        public Department GetById(int id)
        {
            DepartmentRepository repository = new DepartmentRepository();
            return repository.GetById(id);
        }

        public void Update(Department department)
        {
            DepartmentRepository repository = new DepartmentRepository();
            repository.Update(department);
        }
    }
}
