using EmployeeManagement.Models;
using EmployeeManagement.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentService _service;

        public DepartmentsController(IDepartmentService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var dept = _service.GetById(id);

            if (dept == null)
                return NotFound();

            return Ok(dept);
        }

        [HttpPost]
        public IActionResult Add([FromBody] Department department)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(_service.Add(department));
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Department department)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (_service.Update(id, department))
                return Ok("Updated Successfully");

            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (_service.Delete(id))
                return Ok("Deleted Successfully");

            return NotFound();
        }
    }
}