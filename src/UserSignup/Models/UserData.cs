using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserSignup.Models
{
    public class UserData
    {
        private List<User> users = new List<User> {
            new User
            {
                Username = "Username1",
                Password = "password1",
                Email = "email1@gogus.com"
            },
            new User
            {
                Username = "Username2",
                Password = "password2",
                Email = "email2@bogus.com"
            }
        };
        //TODO 2: instantiate a few new users in code here and add them to your users list
        //then write methods to add users to your list, return all users and return a user by UserId

    }
}
