using Lab2.BL.DTOS.Depatment;
using Lab2.BL.Manager.Departments;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentManager DeptManager;

        public DepartmentController(IDepartmentManager deptmanager)
        {
            DeptManager = deptmanager;
        }
        [HttpGet]
        [Route("{id}")]
        public ActionResult<DepartmentDto> GetDetails(int id)
        {
            DepartmentDto? dept = DeptManager.GetById(id);
            if (dept == null)
            {
                return NotFound();
            }
            return dept;
        }
    }
}
