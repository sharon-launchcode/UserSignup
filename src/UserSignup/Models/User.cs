using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserSignup.Models
{
    public class User
    {
        // TODO 1 from vampiire notes
        // create private FIELDS accessed through (protected by) public PROPERTIES 
        private string username;
        private string email;
        private string password;
        // TODO 1: Add UserId, CreateDate and a few more properties of your choosing.  Update the Add and Index views 
        public string Username { get; set; }
        public string Email {
            get => email;

            set {
                email = value;
            }
        }
        public string Password { get; set; }
        //get but not set for ID should it be public or private?
        public int UserId { get; }
        public DateTime CreateDate {
            //get;

            set
            {
                CreateDate = DateTime.Now;
            }

        }

        // add a constructor to set the CreateDate when a new user is instantiated   
        //above constructor is added but I need to figure out what to do with the get
    }

}
