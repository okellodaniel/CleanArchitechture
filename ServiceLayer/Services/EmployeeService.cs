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
            return _repository.GetAll();
        }

        public Employee GetEmployee(int id)
        {
            return _repository.Get(id);
        }

        public void InsertEmployee(Employee employee)
        {
            _repository.insert(employee);
        }

        public void updateEmployee(Employee employee)
        {
            _repository.Update(employee);
        }

        public void DeleteEmployee(int id)
        {
            Employee employee = GetEmployee(id);
            _repository.Remove(employee);
            _repository.SaveChanges();
        }
    }
}