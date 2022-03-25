using ApiTest.DataLayer;
using ApiTest.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApiTest.BusinessLayer
{
    public class ManageEmployee
    {
        public static List<EmployeeEntity> ListEmployee(Expression<Func<EmployeeEntity, bool>> condition)
        {
            return EmployerProvider.List(condition);
        }


        public static bool NewEmployee(EmployeeEntity Employee)
        {
            return EmployerProvider.Add(Employee);
        }

        public static bool DeleteEmployee(EmployeeEntity Employee)
        {
            return EmployerProvider.Remove(Employee);
        }

        public static bool ModifyEmployee(EmployeeEntity Employee)
        {

            return EmployerProvider.Modify(Employee);
        }
    }
}
