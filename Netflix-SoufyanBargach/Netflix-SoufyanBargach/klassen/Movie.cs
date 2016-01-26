using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Netflix_SoufyanBargach
{
    public class Movie
    {
        //Properties
        public int Movieid { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public string Catagorie { get; set; }

        public string Moviename { get; set; }

        public string Language { get; set; }
        public int Year { get; set; }

        //Constructor
        public Movie(int movieid,string director,string genre,string catagorie,string moviename,string language,int year)
        {
            this.Movieid = movieid;
            this.Director = director;
            this.Genre = genre;
            this.Catagorie = catagorie;
            this.Moviename = moviename;
            this.Language = language;
            this.Year = year;
        }

        //Methode
        public override string ToString()
        {
            return Moviename;
        }
    }
}