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
    [Route("api/personne")]
    public class PersonneController : ApiController
    {
        [AllowAnonymous]
        public IEnumerable<PersonneEntity> Get()
        {
            return ManagePersonne.ListPersonne(p => true);
        }

        [AllowAnonymous]
        [Route("api/personne/{id}")]
        public PersonneEntity Get(int id)
        {

            var personne = ManagePersonne.ListPersonne(a => a.Id == id).FirstOrDefault(); //Managepersonne.personneById(id);
            return personne;
        }

        // GET api/tasks/5


        

        [AllowAnonymous]
        [Route("api/personne/{id}")]
        public void Delete(int id)
        {

            var item = ManagePersonne.ListPersonne(i => i.Id == id).FirstOrDefault();
            if (item != null)
                ManagePersonne.DeletePersonne(item);
        }

    }
}
