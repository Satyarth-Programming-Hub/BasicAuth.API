using BasicAuth.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicAuth.API
{
    public class ValidateUser
    {
        //Check if user existis
        public static bool Login(string username, string password) 
        {
            return User.GetUsers().Any(user => user.UserName.Equals(username) && user.Password == password);
        }

        //Get the user details
        public static User GetUserDetails(string username, string password) 
        {
            return User.GetUsers().FirstOrDefault(user => user.UserName.Equals(username) && user.Password == password);
        }
    }
}