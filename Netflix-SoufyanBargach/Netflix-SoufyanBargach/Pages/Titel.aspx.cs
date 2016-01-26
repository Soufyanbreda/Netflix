using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Netflix_SoufyanBargach
{
    public partial class Contact : Page
    {
        private List<Movie> Foundmovies = new List<Movie>();
        private List<Show> Foundseries = new List<Show>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Database.LoggedInUser == null)
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Log in om deze pagina te bekijken');window.location='Home.aspx';", true);
            }
        }

        protected void ChangeVid(object sender, ImageClickEventArgs e)
        {

            if(((ImageButton)sender).ID=="Imagebutton1")
            {
                Videocontrol.Src = "../Movies/video1.mp4";
                Videocontrol.Visible = true;

             }
            if (((ImageButton)sender).ID == "ImageButton2")
            {
                Videocontrol2.Src = "../Movies/video2.mp4";
                Videocontrol2.Visible = true;
                Videocontrol.Visible = false;
            }
            if (((ImageButton)sender).ID == "ImageButton3")
            {
                Videocontrol2.Src = "../Movies/video2.mp4";
                Videocontrol2.Visible = true;
                Videocontrol.Visible = false;
            }
            if (((ImageButton)sender).ID == "ImageButton4")
            {
                Videocontrol2.Src = "../Movies/video2.mp4";
                Videocontrol2.Visible = true;
                Videocontrol.Visible = false;
            }

            if (((ImageButton)sender).ID == "ImageButton5")
            {
                Videocontrol2.Src = "../Movies/video2.mp4";
                Videocontrol2.Visible = true;
                Videocontrol.Visible = false;
            }

            if (((ImageButton)sender).ID == "ImageButton6")
            {
                Videocontrol2.Src = "../Movies/video2.mp4";
                Videocontrol2.Visible = true;
                Videocontrol.Visible = false;
            }
            if (((ImageButton)sender).ID == "ImageButton7")
            {
                Videocontrol2.Src = "../Movies/video2.mp4";
                Videocontrol2.Visible = true;
                Videocontrol.Visible = false;
            }
            if (((ImageButton)sender).ID == "ImageButton8")
            {
                Videocontrol2.Src = "../Movies/video2.mp4";
                Videocontrol2.Visible = true;
                Videocontrol.Visible = false;
            }
            if (((ImageButton)sender).ID == "ImageButton9")
            {
                Videocontrol2.Src = "../Movies/video2.mp4";
                Videocontrol2.Visible = true;
                Videocontrol.Visible = false;
            }
            if (((ImageButton)sender).ID == "ImageButton10")
            {
                Videocontrol2.Src = "../Movies/video2.mp4";
                Videocontrol2.Visible = true;
                Videocontrol.Visible = false;
            }
        }

        public void Zoek(object sender, EventArgs e)
        {
            foreach(Movie m in Database.Movies)
            {
                if(m.Moviename == tbZoek.Text)
                {
                    Foundmovies.Add(m);
                }
            }
            foreach(Show s in Database.Series)
            {
                if(s.Showname == tbZoek.Text)
                {
                    Foundseries.Add(s);
                }
            }
            foreach(Show s in Foundseries)
            {
                Label label1 = new Label();
                label1.Text= s.Showname;
                Panel1.Controls.Add(label1);
            }
            foreach (Movie m in Foundmovies)
            {
                Label label1 = new Label();
                label1.Text = m.Moviename;
                Panel1.Controls.Add(label1);
            }
        }
    }
}