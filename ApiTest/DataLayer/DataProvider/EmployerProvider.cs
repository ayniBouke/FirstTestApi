using ApiTest.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApiTest.DataLayer 
{
    public class EmployerProvider 
        {
            private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            /// <summary>
            /// Adds a new cartProduct to the database.
            /// </summary>
            /// <param name="ayni">The Id property is automatically generated.</param>
            /// <returns></returns>
            public static bool Add(EmployeeEntity empl)
            {
                if (empl == null)
                    return false;


                var result = DatabaseConnection.Add<EmployeeEntity>(empl);
                return result;
            }
            public static bool IsExist(Expression<Func<EmployeeEntity, bool>> condition)
            {
                return DatabaseConnection.IsExist<EmployeeEntity>(condition);
            }



            /// <summary>
            /// Modifies a cartProduct in the database.
            /// </summary>
            /// <param name="ayni">The Id property cannot be modified.</param>
            /// <returns></returns>
            public static bool Modify(EmployeeEntity empl)
            {
                if (empl == null)
                    return false;

                using (var context = new ApiTestContext(DatabaseConnection.ConnectionString))
                {

                    context.Entry<EmployeeEntity>(empl).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                    return true;
                }
            }

            /// <summary>
            /// Removes a cartProduct from the database with the same Id.
            /// </summary>
            /// <param name="cartProduct">The Id property selects the cartProduct.</param>
            /// <returns></returns>
            public static bool Remove(EmployeeEntity empl)
            {
                if (empl == null)
                    return false;
                return DatabaseConnection.Remove<EmployeeEntity>(c => c.ID == empl.ID);
            }
            public static List<EmployeeEntity> List(Expression<Func<EmployeeEntity, bool>> condition)
            {
                using (var context = new ApiTestContext(DatabaseConnection.ConnectionString))
                {
                    var list = context.EmployeeEntities.Where(condition).ToList();
                    return list;
                }
            }
           

            
         
    }

}