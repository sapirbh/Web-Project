using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class UsersDataAccess
    {
        ypaEntities db;

        public user CheckLogin(string userEmail, string password)
        {
            return db.users.Where(u => u.Email == userEmail && u.Password == password).FirstOrDefault();
        }

        public user AddUser(string userEmail, string firstName, string lastName, string password)
        {
            if (db.users.Any(u => u.Email == userEmail))
                return null;
            user NewUser = new user(firstName, lastName, userEmail, password);
            db.users.Add(NewUser);
            return NewUser;
        }

    }
}