using System.Collections.Generic;
using DomainLayer.Models;

namespace ServiceLayer.Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployee(int id);
        void InsertEmployee(Employee employee);
        void updateEmployee(Employee employee);
        void DeleteEmployee (int id);

    }
}