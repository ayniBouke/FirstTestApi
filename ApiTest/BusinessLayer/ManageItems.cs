using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using ApiTest.DataLayer;
using ApiTest.EntityLayer;

namespace ApiTest.BusinessLayer
{
    public class ManageItems
    {
        public static List<TodoItemEntity> ListItem(Expression<Func<TodoItemEntity, bool>> condition) { 
            return ItemsProvider.List(condition);
        }

        public static bool AddItem(TodoItemEntity item) {
            return ItemsProvider.Add(item);
        }

        public static bool EditItem(TodoItemEntity item)
        {
            return ItemsProvider.Modify(item);
        }
        public static bool RemoveItem(TodoItemEntity item)
        {
            return ItemsProvider.Remove(item);
        }
    }
}