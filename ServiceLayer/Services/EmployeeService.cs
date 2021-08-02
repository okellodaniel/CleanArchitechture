using System.Collections.Generic;
using DomainLayer.Models;
using RepositoryLayer.Repository;

namespace ServiceLayer.Services
{
    public class EmployeeService : IEmployeeService
    {
        private IRepository<Employee> _repository;

        public EmployeeService(IRepository<Employee> repository)
        {
            _repository = repository;
        }
        
        public IEnumerable<Employee> GetAllEmployees()
        {
            throw new System.NotImplementedException();
        }

        public Employee GetEmployee(int id)
        {
            throw new System.NotImplementedException();
        }

        public void InsertEmployee(Employee employee)
        {
            throw new System.NotImplementedException();
        }

        public void updateEmployee(Employee employee)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteEmployee(int id)
        {
            Employee employee = GetEmployee(id);
            _repository.Remove(employee);
            _repository.SaveChanges();
        }
    }
}