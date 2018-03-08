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
        private int userid;
        //will need to convert to string from datetime
        private DateTime createdate;
        // TODO 1: Add UserId, CreateDate and a few more properties of your choosing.  Update the Add and Index views 
        public string Username
        {
            get => username;
            set
            {
                username = value;
            }

        }
        public string Email {
            get => email;

            set {
                email = value;
            }
        }
        public string Password {
            get => password;
            //password has aready been set to private above

            set {
                    //below if example from vampiire lecture
                    if (value.Length < 5)
                    {
                        throw new ArgumentException("Password is too short.");
                    }
                    if (value.Length > 15)
                    {
                        throw new ArgumentException("Password is too long.");
                    }

                password = value;
                }

        }
        //For password the getter should be private
        //get but not set for ID should it be public or private?

        // from vampiire counter of all users that have been instantiated (prevents overlapping IDs)
        // from vampiire static so it is at the Class level (can be counted globally outside of all User instances)
        private static int NextId = 0;

        // from vampiire can only be set internally (private setter)
        //from vampiire  defaults to the CURRENT VALUE of NextId and THEN increments NextId for the next instantiation
        // from vampiire POSTfix increment (Variable++) opposed to PREfix increment (++Variable)
        public int UserId { get; } = NextId++;


        public DateTime CreateDate {
            get => createdate;

            set
            {
                CreateDate = DateTime.Now;
            }

        }

        // add a constructor to set the CreateDate when a new user is instantiated   
        //above constructor is added but I need to figure out what to do with the get
        //note to self was able to add a body to get after private variable created with DateTime data type
    }

}
