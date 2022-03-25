using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using ApiTest.EntityLayer;

namespace ApiTest.DataLayer
{
    public class ItemsProvider
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Adds a new cartProduct to the database.
        /// </summary>
        /// <param name="ayni">The Id property is automatically generated.</param>
        /// <returns></returns>
        public static bool Add(TodoItemEntity item)
        {
            if (item == null)
                return false; 

            var result = DatabaseConnection.Add<TodoItemEntity>(item);
            return result;
        }
        public static bool IsExist(Expression<Func<TodoItemEntity, bool>> condition)
        {
            return DatabaseConnection.IsExist<TodoItemEntity>(condition);
        }



        /// <summary>
        /// Modifies a cartProduct in the database.
        /// </summary>
        /// <param name="ayni">The Id property cannot be modified.</param>
        /// <returns></returns>
        public static bool Modify(TodoItemEntity item)
        {
            if (item == null)
                return false;

            using (var context = new ApiTestContext(DatabaseConnection.ConnectionString))
            {

                context.Entry<TodoItemEntity>(item).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return true;
            }
        }

        /// <summary>
        /// Removes a cartProduct from the database with the same Id.
        /// </summary>
        /// <param name="cartProduct">The Id property selects the cartProduct.</param>
        /// <returns></returns>
        public static bool Remove(TodoItemEntity item)
        {
            if (item == null)
                return false;
            return DatabaseConnection.Remove<TodoItemEntity>(c => c.Id == item.Id);
        }
        public static List<TodoItemEntity> List(Expression<Func<TodoItemEntity, bool>> condition)
        {
            using (var context = new ApiTestContext(DatabaseConnection.ConnectionString))
            {
                var list = context.Items.Where(condition).ToList();
                return list;
            }
        }


    }
}