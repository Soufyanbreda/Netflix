using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Netflix_SoufyanBargach
{
    public class User : Account
    {
        


        //Constructor

        public User(string username,string password, string gender,string firstname,string lastname,  string isadmin):base(username,password,gender,firstname,lastname, isadmin)
        { }
       
        //Constructor voor inloggen
     
     //Methode
        public override string ToString()
        {
            return base.ToString();
        }
       
        
    }
}