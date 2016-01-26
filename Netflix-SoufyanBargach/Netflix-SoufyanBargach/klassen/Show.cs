using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Netflix_SoufyanBargach
{
    public class Show
    {
        //Properties
        public int Showid { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public string Catagorie { get; set; }
        public string Showname { get; set; }

       
        public int Year { get; set; }

        //Constructor
        public Show(int movieid,string director,string genre,string catagorie,string moviename,int year)
        {
            this.Showid = movieid;
            this.Director = director;
            this.Genre = genre;
            this.Catagorie = catagorie;
            this.Showname = moviename;
            
            this.Year = year;
        }

        //Methode
        public override string ToString()
        {
            return Showname;
        }



    }
}