using ApiTest.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApiTest.DataLayer
{
    public class PersonneProvider
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Adds a new cartProduct to the database.
        /// </summary>
        /// <param name="ayni">The Id property is automatically generated.</param>
        /// <returns></returns>
        public static bool Add(PersonneEntity personne)
        {
            if (personne == null) 
                return false; 

            var result = DatabaseConnection.Add<PersonneEntity>(personne);
            return result;
        }
        public static bool IsExist(Expression<Func<PersonneEntity, bool>> condition)
        {
            return DatabaseConnection.IsExist<PersonneEntity>(condition);
        }



        /// <summary>
        /// Modifies a cartProduct in the database.
        /// </summary>
        /// <param name="ayni">The Id property cannot be modified.</param>
        /// <returns></returns>
        public static bool Modify(PersonneEntity personne)
        {
            if (personne == null)
                return false;

            using (var context = new ApiTestContext(DatabaseConnection.ConnectionString))
            {

                context.Entry<PersonneEntity>(personne).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return true;
            }
        }

        /// <summary>
        /// Removes a cartProduct from the database with the same Id.
        /// </summary>
        /// <param name="cartProduct">The Id property selects the cartProduct.</param>
        /// <returns></returns>
        public static bool Remove(PersonneEntity personne)
        {
            if (personne == null)
                return false;
            return DatabaseConnection.Remove<PersonneEntity>(c => c.Id == personne.Id);
        }
        public static List<PersonneEntity> List(Expression<Func<PersonneEntity, bool>> condition)
        {
            using (var context = new ApiTestContext(DatabaseConnection.ConnectionString))
            {
                var list = context.PersonneEntities.Where(condition).ToList();
                return list;
            }
        }
         
    }

}