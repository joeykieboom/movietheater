using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace dotnet_core_theater.Models
{
    public class UserModel : IdentityUser
    {
        public int UserID { get; set; }
        public string Password { get; set; }
        
        public UserModel(string userName, string password, string email)
        {
            UserName = userName;
            Password = password;
            Email = email;
        }

        public UserModel(string UserID)
        {

        }
    }
}