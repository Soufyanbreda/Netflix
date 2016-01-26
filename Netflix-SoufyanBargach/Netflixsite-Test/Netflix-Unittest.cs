using System;
using Netflix_SoufyanBargach;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Netflixsite_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestgetMovie()
        {
            Movie movie = new Movie(6, "scorcese", "horror", "aktie", "scarface", "nl", 1994);
            movie.Moviename = "scarface";
            Assert.AreEqual("scarface", movie.Moviename, "Check if movie name is equal");
        }
    }
}
