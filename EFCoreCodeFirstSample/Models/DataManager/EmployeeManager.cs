using System.Collections.Generic;
using System.Linq;
using EFCoreCodeFirstSample.Models.Repository;

namespace EFCoreCodeFirstSample.Models.DataManager
{
    public class EmployeeManager : IDataRepository<Employee>
    {
        readonly EmployeeContext _employeeContext;

        public EmployeeManager(EmployeeContext context)
        {
            _employeeContext = context;
        }

        public IEnumerable<Employee> GetAll()
        {
            return _employeeContext.Employees.ToList();
        }

        public Employee Get(long id)
        {
            return _employeeContext.Employees.FirstOrDefault(e => e.EmployeeId == id);
        }

        public int Add(Employee entity)
        {
            _employeeContext.Employees.Add(entity);
            return _employeeContext.SaveChanges();
        }

        public int Update(long id, Employee entity)
        {
            Employee employee = _employeeContext.Employees.Find(id);

            if (employee == null)
            {
                return 0;
            }

            employee.FirstName = entity.FirstName;
            employee.LastName = entity.LastName;
            employee.Email = entity.Email;
            employee.DateOfBirth = entity.DateOfBirth;
            employee.PhoneNumber = entity.PhoneNumber;

            return _employeeContext.SaveChanges();
        }

        public int Delete(long id)
        {
            Employee employee = _employeeContext.Employees.FirstOrDefault(e => e.EmployeeId == id);

            if (employee == null)
            {
                return 0;
            }

            _employeeContext.Employees.Remove(employee);
            return _employeeContext.SaveChanges();
        }
    }
}
