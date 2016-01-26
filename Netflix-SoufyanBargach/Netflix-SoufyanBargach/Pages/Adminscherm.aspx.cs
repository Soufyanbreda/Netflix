using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Netflix_SoufyanBargach.Pages
{
    public partial class Adminscherm : System.Web.UI.Page
    {
        private List<Movie> movies;
        private List<Show> series;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                Tab1.CssClass = "Clicked";
                MainView.ActiveViewIndex = 0;
                Update();
            }
            if(Database.LoggedInUser != null)
            {
                if (Database.LoggedInUser.Isadmin == false)
                {
                    ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('U heeft niet de rechten om deze pagina te bekijken');window.location='Home.aspx';", true);
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Log eerst in omd eze pagina te kunnen bekijken');window.location='Home.aspx';", true);
            }
        }

        //Update methode voor listboxes
            public void Update()
            {
                 lbFilms.Items.Clear();
                 lbSerie.Items.Clear();
                 movies = Database.Instance.LaadFilms();
            series = Database.Instance.LaadSeries();

           foreach (Movie movie in movies)
           {
               lbFilms.Items.Add(movie.ToString());
            }
            foreach (Show show in series)
            {
                lbSerie.Items.Add(show.ToString());
           }

            }
            

       

        //Tabs moeten appearen

        protected void Tab1_Click(object sender, EventArgs e)
        {
            PanelFilms.Visible = true;
            MainView.ActiveViewIndex = 0;
        }

        protected void Tab2_Click(object sender, EventArgs e)
        {
            PanelSerie.Visible = true;
            MainView.ActiveViewIndex = 1;
        }

        protected void btnChangeNaam_Click(object sender, EventArgs e)
        {
            PanelUpdate.Visible = true;
        }

        //De naam van de film moet in de textbox komen te staan
        protected void lbFilms_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbNaam.Text = lbFilms.SelectedValue;
        }

        //De tekst in de textbox moet in de listbox worden vervangen

        protected void btnBevestig_Click(object sender, EventArgs e)
        {
              if (lbFilms.SelectedIndex != -1)
            {
                lbFilms.Items[lbFilms.SelectedIndex].Text = tbNaam.Text;
                
            }
          
            lbFilms.SelectedIndex = -1;
        }

        protected void btnSerieVerwijderen_Click(object sender, EventArgs e)
        {
           // Database.Instance.VerwijderFilm(movies[lbFilms.SelectedIndex]);
            Update();
        }

        protected void btnFilm_Click(object sender, EventArgs e)
        {
            Update();
            Movie movie = movies[(lbFilms.SelectedIndex + 1)];
            Database.Instance.VerwijderFilm(movie);
            movies.Remove(movies[lbFilms.SelectedIndex]);
            Update();
        }

        
        

        

       

       

      

        
    }
}