using ApiTest.BusinessLayer;
using ApiTest.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ApiTest.Controllers
{
    //[Authorize]
    [Route("api/employee")]
    public class EmployeeController : ApiController
    {
        [AllowAnonymous]
        public IEnumerable<EmployeeEntity> Get()
        {
            return ManageEmployee.ListEmployee(p => true);
        }

        [AllowAnonymous]
        [Route("api/employee/{id}")]
        public EmployeeEntity Get(int id)
        {

            var employee = ManageEmployee.ListEmployee(a => a.ID == id).FirstOrDefault(); //Managepersonne.personneById(id);
            return employee;
        }


        // POST api/tasks

        [AllowAnonymous]
        // [Route("api/labels/add")]
        [Route("api/employee/")]
        public EmployeeEntity Post([FromBody] EmployeeEntity empl)
        {
            var result = false; 

            if (empl.ID > 0)
            {
                result = ManageEmployee.ModifyEmployee(empl);
            }
            else
            {
                result = ManageEmployee.NewEmployee(empl);
            }
             
            return result ? empl :null;
        }


        [AllowAnonymous]
        [Route("api/employee/{id}")]
        public void Delete(int id)
        {

            var item = ManageEmployee.ListEmployee(i => i.ID == id).FirstOrDefault();
            if (item != null)
                ManageEmployee.DeleteEmployee(item);
        }

    }
}
