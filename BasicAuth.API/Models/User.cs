using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicAuth.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Roles { get; set; }
        public string Email { get; set; }

        public static List<User> GetUsers() 
        {
            List<User> users = new List<User>() 
            { 
            new User{Id=1001,UserName="NormalUser",Password="12345",Roles="User",Email="user@email.com" },
            new User{Id=1001,UserName="AdminUser",Password="12345",Roles="User,Admin",Email="user@email.com" },
            new User{Id=1001,UserName="SuperAdminlUser",Password="12345",Roles="User,Admin,SuperAdmin",Email="user@email.com" },
            };
            return users;
        }
    }
}