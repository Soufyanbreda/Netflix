using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Netflix_SoufyanBargach
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistreer_Click(object sender, EventArgs e)
        {
           
            //dit moet een gebruiker invullen
            string username = tbUsername.Text;
            
            string wachtwoord = tbPassword.Text;
            
            string gender = tbGender.Text;
            string firstname = tbFirstname.Text;
            string lastname = tbLastname.Text;
            
            //Nieuwe gebruiker aanmaken
 Netflix_SoufyanBargach.Account nieuweaccount = new Netflix_SoufyanBargach.Account(username,wachtwoord,gender,firstname,lastname, "n");
            
            Database.Instance.Registreren(nieuweaccount, wachtwoord);
            
            //Na het registreren worden gebruikers naar de loginpagina gestuurd
            Response.Redirect("Login.aspx");
        }
    }
}