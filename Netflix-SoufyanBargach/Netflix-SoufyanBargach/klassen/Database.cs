using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

using Oracle.ManagedDataAccess.Client;
using System.Diagnostics;




namespace Netflix_SoufyanBargach
{
    public class Database
    {
        private static Database instance;
        public Account account;
        public static Account LoggedInUser { get; set; }
        public static List<Account> Accounts { get; set; }
        public static List<Movie> Movies { get; set; }
        public static List<Show> Series { get; set; }
        
        public static Database Instance // the singleton
        {
            get { return instance ?? (instance = new Database()); }
        }

        private Database()
        {

            using (OracleConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                }
                catch (OracleException e)
                {
                    Debug.WriteLine("Kon geen verbinding maken met de Oracle database, Error: " + e.Message);
                }
            }
            Accounts = LaadAccount();
            Movies = LaadFilms();
            Series = LaadSeries();
        }

        //QUERY om connectie te maken met oracle
        private static OracleConnection GetConnection()
        {
            return
                new OracleConnection(
                    "User Id=dbi330089;Password=cinvfJOnOc;Data Source=fhictora01.fhict.local:1521/fhictora;");
        }

        public bool Hasconnection()
        {
            using (OracleConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                }
                catch (OracleException e)
                {
                    Debug.WriteLine("Kon geen verbinding maken met de Oracle database, Error: " + e.Message);
                    return false;
                }
            }

            return true;
        }


        //Querie om In te loggen

        public Account Login(string username, string password)
        {
            Account user = null;
            using (OracleConnection conn = GetConnection())
            {
                conn.Open();
                string query = "Select * from account where username ='" + username
                               + "' and pasword ='" + password + "'";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string wachtwoord = reader["pasword"].ToString();
                            string gebruikersnaam = reader["username"].ToString();

                            if (password == wachtwoord && username == gebruikersnaam)
                            {
                                foreach(Account a in Database.Accounts)
                                {
                                    if(a.Username == username && a.Password == password)
                                    {
                                        Database.LoggedInUser = a;
                                        user = a;
                                    }
                                }
                            }
                        }
                    }
                }

                return user;
            }
        }

        public int Getmaxuser()
        {
            int maxuser = 0;
            using (OracleConnection conn = GetConnection())
            {
                conn.Open();
                string query = "select count(*) +1 as accountid from account";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            maxuser = Convert.ToInt32(reader["accountid"]);
                        }
                    }
                }
            }
            return maxuser;
        }
       //Querie om een user te registreren
        public void Registreren(Account account, string password)
        {
            using (OracleConnection conn = GetConnection())
            {
                try
                {
                        string query = "INSERT INTO \"ACCOUNT\"(accountid, username,pasword,gender,firstname,surname) VALUES ("+ Getmaxuser() + ", '" + account.Username +"', '"+  account.Password +"', '"+  account.Gender +"', '"+  account.Firstname + "', '"+  account.Lastname + "')";
                        conn.Open();

                        using (OracleCommand cmd = new OracleCommand(query, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                
                catch(OracleException ex)
                {
                    Debug.WriteLine(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        /// <summary>
        ///  Query om films op te halen
        /// </summary>
        /// <returns></returns>
        internal List<Movie> LaadFilms()
        {
            List<Movie> movies = new List<Movie>();
            using (OracleConnection conn = GetConnection())
            {
                conn.Open();
                string query = "Select * from MOVIE";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            movies.Add(new Movie(Convert.ToInt32(reader["Movieid"]), reader["Director"].ToString(), reader["Genre"].ToString(),
                            reader["catagorie"].ToString() , reader["moviename"].ToString(), reader["language"].ToString(), Convert.ToInt32(reader["year"])));
                        }
                    }
                }
                conn.Close();
            }
            return movies;
        }
        internal List<Account> LaadAccount()
        {
            List<Account> account = new List<Account>();
            using (OracleConnection conn = GetConnection())
            {
                conn.Open();
                string query = "Select * from Account";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            account.Add(new Account( reader["username"].ToString(), reader["pasword"].ToString(),
                            reader["gender"].ToString(), reader["firstname"].ToString(), reader["surname"].ToString(), reader["isadmin"].ToString()));
                        }
                    }
                }
                conn.Close();
            }
            return account
;
        }

        //Query om series op te halen
        public List<Show> LaadSeries()
        {
            List<Show> series = new List<Show>();
            using (OracleConnection conn = GetConnection())
            {
                conn.Open();
                string query = "Select * from SHOW";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            series.Add(new Show(Convert.ToInt32(reader["Showid"]), reader["Director"].ToString(), reader["Genre"].ToString(),
                            reader["catagorie"].ToString(), reader["showname"].ToString(),  Convert.ToInt32(reader["year"])));
                        }
                    }
                }
                conn.Close();
            }
            return series;
        }

        //Query om film te verwijderen
        public void VerwijderFilm(Movie movie)
        {
            string query = "DELETE FROM Movie WHERE Movieid = " + movie.Movieid;

            using (OracleConnection conn = GetConnection())
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        //Query om serie te verwijderen

        public void VerwijderSerie(Show show)

        {
            string query = string.Format("DELETE FROM Movie WHERE ID = {0}", show);

            using (OracleConnection conn = GetConnection())
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
             