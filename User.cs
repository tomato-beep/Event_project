using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project
{
    class User
    {
        public string userName, UserEmail, UserPassword, UserCountry , UserNationalID;
        public User  ()
        {
            userName = "";
            UserEmail = "";
            UserPassword = "";
            UserCountry = "";
            UserNationalID = "";
        }
        public User(string name , string email , string password , string country , string nationalID)
        {
            userName = name;
            UserEmail = email;
            UserPassword = password;
            UserCountry = country;
            UserNationalID = nationalID;
        }
    }
}
