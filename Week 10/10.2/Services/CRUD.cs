using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mod7CodeFirstdemo.Models;
using Mod7CodeFirstdemo.Data;

namespace Mod7CodeFirstdemo.Services
{
    public class CRUD
    {
        //object getting added in dbset (local copy)
        public void AddRecord(Employee employee)
        {
            Records.employeeContext.Employees.Add(employee);
            Records.employeeContext.SaveChanges();
        }

        public Employee FindEmployee(int id)
        { 
            return Records.employeeContext.Employees.Find(id); 
        }



        public void DeleteRecord(int eid)
        {
            var emp = Records.employeeContext.Employees.Find(eid);
            if (emp != null)
            {
                Records.employeeContext.Employees.Remove(emp);
                Records.employeeContext.SaveChanges();
            }
        }

        public void UpdateRecord(int id, Employee emp)
        {
            var emptoupdate = Records.employeeContext.Employees.Find(id);
            if (emptoupdate != null)
            {
                emptoupdate.EmpId = emp.EmpId;
                emptoupdate.Name = emp.Name;
                emptoupdate.Salary = emp.Salary;
                emptoupdate.DepartmentID = emp.DepartmentID;
                Records.employeeContext.SaveChanges();
            }
        }

        public int GetMaxId()
        {
            return Records.employeeContext.Employees.Max(e => e.EmpId);//LAMBDA EXPRESSION
        }

        public ICollection <Employee> GetEmployees()
        {
            return Records.employeeContext.Employees.ToList();
        }

        public ICollection<Department> GetDepartments()
        {
            return Records.employeeContext.Departments.ToList();
        }
    }
}
