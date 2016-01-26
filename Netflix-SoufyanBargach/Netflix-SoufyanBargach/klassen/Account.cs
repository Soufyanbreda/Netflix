using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Netflix_SoufyanBargach
{
    public class Account
    {
        //Properties
        public string Username { get; set; }

        public string Password { get; set; }
        //public int Accountid { get; set; }

        public string Gender { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }
        public bool Isadmin { get; set; }

       



        //Constructor
        public Account(string username,string password,string gender,string firstname,string lastname, string isadmin)
        {
            this.Username = username;
            this.Password = password;
            //this.Accountid = accountid;
            this.Gender = gender;
            this.Firstname = firstname;
            this.Lastname = lastname;
            if(isadmin == "y")
            {
                this.Isadmin = true;
            }
            else
            {
                this.Isadmin = false;
            }
        }

        public Account(string username,string password)
        {
            this.Username = username;
            this.Password = password;
        }


    }
}