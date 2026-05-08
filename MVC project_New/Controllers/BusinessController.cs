using Microsoft.AspNetCore.Mvc;

namespace MVC_project_New.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BusinessController : ControllerBase
    {
        [Route("{EmployeeId:int}")]
        [HttpPost]
        public string GetEmployeeDetails(int EmployeeId)
        {

            return $"Response from GetEmployeeDetails Method, EmployeeId : {EmployeeId}";
        }

        [Route("{EmployeeName}")]
        [HttpPost]
        public string GetEmployeeDetails(string EmployeeName)
        {
            return $"Response from GetEmployeeDetails Method, EmployeeName : {EmployeeName}";
        }
    }
}
