using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectDatamanipulatieAnime_Models;

namespace Anime_UnitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void ProjectlidVenster_NaamIsGelijkAanValue()
        {
            //Arrange
            ProjectlidVenster projectlidVenster = new ProjectlidVenster("","","","");

            //Act
            projectlidVenster.Naam = "naam";

            //Assert
            Assert.AreEqual(projectlidVenster.Naam, "naam");

        }
        [TestMethod]
        public void ProjectlidVenster_VoornaamIsGelijkAanValue()
        {
            //Arrange
            ProjectlidVenster projectlidVenster = new ProjectlidVenster("", "", "", "");

            //Act
            projectlidVenster.Voornaam = "voornaam";

            //Assert
            Assert.AreEqual(projectlidVenster.Voornaam, "voornaam");

        }
        [TestMethod]
        public void ProjectlidVenster_WoonplaatsIsGelijkAanValue()
        {
            //Arrange
            ProjectlidVenster projectlidVenster = new ProjectlidVenster("", "", "", "");

            //Act
            projectlidVenster.Woonplaats = "woonplaats";

            //Assert
            Assert.AreEqual(projectlidVenster.Woonplaats, "woonplaats");

        }
        [TestMethod]
        public void ProjectlidVenster_NaamvensterIsGelijkAanValue()
        {
            //Arrange
            ProjectlidVenster projectlidVenster = new ProjectlidVenster("", "", "", "");

            //Act
            projectlidVenster.NaamVenster = "naamvenster";

            //Assert
            Assert.AreEqual(projectlidVenster.NaamVenster, "naamvenster");

        }
        [TestMethod]
        public void ProjectlidVenster_TostringIsGelijkAanValue()
        {
            //Arrange
            ProjectlidVenster projectlidVenster = new ProjectlidVenster("naam", "voornaam", "woonplaats", "naamvenster");

            //Act
            string result = projectlidVenster.ToString();

            //Assert
            Assert.AreEqual(projectlidVenster.ToString(), result);

        }
        [TestMethod]
        public void ProjectlidVenster_ValideerLeegIsGelijkAanValue()
        {
            //Arrange
            ProjectlidVenster projectlidVenster = new ProjectlidVenster("", "", "", "");

            //Act
            string result = projectlidVenster.Valideer("");

            //Assert
            Assert.AreEqual(projectlidVenster.Valideer(""), result);

        }
        [TestMethod]
        public void ProjectlidVenster_ValideerIngevuldIsGelijkAanValue()
        {
            //Arrange
            ProjectlidVenster projectlidVenster = new ProjectlidVenster("naam", "voornaam", "woonplaats", "naamvenster");

            //Act
            string result = projectlidVenster.Valideer("voornaam");

            //Assert
            Assert.AreEqual(projectlidVenster.Valideer("voornaam"), result);

        }


    }
}
