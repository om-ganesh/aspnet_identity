using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1
{
    public class EmployeeController : ApiController
    {

        // GET: api/Employee
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, GetEmployees());
        }

        // GET: api/Employee/5
        public HttpResponseMessage Get(int id)
        {
            var data = GetEmployees().Where(x => x.id == id).FirstOrDefault();
            if (data == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, " Employee Not Found");
            }
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        private Employee[] GetEmployees()
        {
            return new Employee[] {
                new Employee() { id= 1, name= "Ram", age=30 },
                new Employee() { id= 2, name= "Hari", age=38 },
                new Employee() { id= 2, name= "Shyam", age=38 },
                new Employee() { id= 2, name= "Balli", age=38 },
                new Employee() { id= 3, name= "Radha", age=43 },
                new Employee() { id= 4, name= "Krishna", age=41 },
            };
        }
    }
}
