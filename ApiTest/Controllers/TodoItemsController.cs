using System;
using System.Collections.Generic;
using System.Linq;
using System.Web; 
using System.Web.Http;
using ApiTest.BusinessLayer;
using ApiTest.EntityLayer;
using System.Threading.Tasks;

namespace ApiTest.Controllers
{
    [Route("api/items")]
    public class TodoItemsController : ApiController
    {
        // var newPaaswrd = Helper.GetHash(user.Password);
        // GET: TodoItems
        public List<TodoItemEntity> Get()
        {
            var result = ManageItems.ListItem(obj => true);
            return result;
        }
        [Route("api/items/{id}")]
        public TodoItemEntity Get(int id)
        {
            var result = ManageItems.ListItem(obj => obj.Id == id).FirstOrDefault();
            return result;
        }
        public bool Post(TodoItemEntity item)
        {
            var result = false;

            if (item.Id == 0) {
                result = ManageItems.AddItem(item);
            }
            else {
                result = ManageItems.EditItem(item); 
            }
            
            return result;
        }
        [Route("api/items/{id}")]
        public bool Delete(int id)
        {
            var item = ManageItems.ListItem(itm => itm.Id == id).FirstOrDefault();
            var result = false;
            if (item != null)
            {
                result = ManageItems.RemoveItem(item);
            }
            return result;
        }
    }
}