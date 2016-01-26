using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Netflix_SoufyanBargach.Pages
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_Click(object sender, EventArgs e)
        {
            //Gebruiker moet inlog naam en wachtwoord invullen
            string gebruikersnaam = tbUsername.Text;
            string wachtwoord = tbPassword.Text;

            //Database query werkt niet
            Database.Instance.Login((gebruikersnaam), wachtwoord.ToString());

            //Na inloggen gaan gebruikers naar de titel pagina waar ze films kunnen kijken
            Response.Redirect("Titel.aspx");
       }

    }
}