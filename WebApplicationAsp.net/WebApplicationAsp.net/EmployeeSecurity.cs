using EmployeeDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationAsp.net
{
    public class EmployeeSecurity
    {
        public static bool Login(string userName, string password)
        {
            using (EmployeeDBEntities entities = new EmployeeDBEntities())
            {
                return entities.Users.Any(user => user.Username.Equals(userName, StringComparison.OrdinalIgnoreCase) && user.Password == password);
            }
        }
    }
}