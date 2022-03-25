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
    public class ManagePersonne
    {
        public static List<PersonneEntity> ListPersonne(Expression<Func<PersonneEntity, bool>> condition)
        {
            return PersonneProvider.List(condition);
        }


        public static bool NewPersonne(PersonneEntity personne)
        {
            return PersonneProvider.Add(personne);
        }

        public static bool DeletePersonne(PersonneEntity personne)
        {
            return PersonneProvider.Remove(personne);
        }

        public static bool ModifyPersonne(PersonneEntity personne)
        {

            return PersonneProvider.Modify(personne);
        }
    }
}
