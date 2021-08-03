using DomainLayer.Models;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class EmployeeController : Controller
    {
       private readonly IEmployeeService _employeeService;
        // GET
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        
        public IActionResult GetAllEmployees()
        {
            var res = _employeeService.GetAllEmployees();
            if (res is not null)
            {
                return Ok(res);
            }
            return BadRequest("No Records Found");
        }
        
        [HttpGet(nameof(GetEmployee))]
        public IActionResult GetEmployee(int id)
        {
            var res = _employeeService.GetEmployee(id);
            if (res is not null)
            {
                return Ok(res);
            }
            return BadRequest("No Records Found");
        }
        
        [HttpPost(nameof(InsertEmployee))]
        public IActionResult InsertEmployee(Employee employee)
        {
         _employeeService.InsertEmployee(employee);
         return Ok("Data Saved");

        }
        
        [HttpPut(nameof(UpdateEmployee))]
        public IActionResult UpdateEmployee(Employee employee)
        {
            _employeeService.updateEmployee(employee);
            return Ok("Data Updated");

        }
        
        [HttpDelete(nameof(DeleteEmployee))]
        public IActionResult DeleteEmployee(int id)
        {
            _employeeService.DeleteEmployee(id);
            return Ok("Data Deleted");
        }
    }
}