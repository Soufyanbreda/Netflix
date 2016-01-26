using System;
using Netflix_SoufyanBargach;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Netflixsite_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAccount()
        {
            Account account = new Account("Soufyan", "wachtwoord");
           Assert.AreEqual("Soufyan", account.Username, "Check if username is equal");
            Assert.AreEqual("wachtwoord",account.Password, "Check if password is equal");
        }
        [TestMethod]
        public void TestMovie()
        {
            Movie movie = new Movie(6, "scorcese", "horror", "aktie", "scarface", "nl", 1994);
            movie.Moviename = "scarface";
            Assert.AreEqual("scarface", movie.Moviename, "Check if movie name is equal");
        }
        [TestMethod]
        public void TestShow()
        {
            Show show = new Show(7, "tarentino", "horror", "comedy", "breakingbad");
            show.Showname = "breakingbad";
            Assert.AreEqual("breakingbad", show.Showname, "Check if show name is equal");
        }


    }
}
