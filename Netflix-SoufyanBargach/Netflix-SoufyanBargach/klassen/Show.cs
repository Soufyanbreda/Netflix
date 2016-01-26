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
        public Show(int showid,string director,string genre,string catagorie,string showname)
        {
            this.Showid = showid;
            this.Director = director;
            this.Genre = genre;
            this.Catagorie = catagorie;
            this.Showname = showname;
            
            
        }

        //Methode
        public override string ToString()
        {
            return Showname;
        }



    }
}