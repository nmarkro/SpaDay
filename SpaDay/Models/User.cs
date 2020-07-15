using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Models
{
    public class User
    {
        [FromForm(Name ="username")]
        public string Username { get; set; }
        [FromForm(Name = "email")]
        public string Email { get; set; }
        [FromForm(Name = "password")]
        public string Password { get; set; }


        public User() { }

        public User(string username, string email, string password)
        {
            this.Username = username;
            this.Email = email;
            this.Password = password;
        }
    }
}
