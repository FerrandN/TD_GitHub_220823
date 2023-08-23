using Microsoft.VisualStudio.TestTools.UnitTesting;
using NuGet.Frameworks;
using src;

namespace TestUnitaires
{
    [TestClass]
    public class TestUnitairePerson
    {
        [TestMethod]
        public void Person_Constructeur_Nom_BOUNATIROU_Prenom_Rodolphe_InstanciationOk()
        {
            Person p = new Person("BOUNATIROU", "Rodolphe");
            Assert.IsTrue(p.Nom == "BOUNATIROU", "Nom incorrect");
            Assert.IsTrue(p.Prenom == "Rodolphe", "Prenom incorrect");
        }

        [TestMethod]
        public void Person_Constructeur_Nom_null_Prenom_Rodolphe_Exception()
        {
            Assert.ThrowsException<Exception>(()=>new Person(null, "Rodolphe"),
                "Pas d'exception a l'instanciation d'une personne avec un nom null");
        }

        [TestMethod]
        public void Person_Constructeur_Nom_BOUNATIROU_Prenom_null_Exception()
        {
            Assert.ThrowsException<Exception>(() => new Person("BOUNATIROU", null),
                "Pas d'exception a l'instanciation d'une personne avec un prenom null");
        }

        [TestMethod]
        public void Person_Constructeur_Nom_chainevide_Prenom_Rodolphe_Exception()
        {
            Assert.ThrowsException<Exception>(() => new Person("", "Rodolphe"),
                "Pas d'exception a l'instanciation d'une personne avec un nom vide");
        }

        [TestMethod]
        public void Person_Constructeur_Nom_BOUNATIROU_Prenom_chainevide_Exception()
        {
            Assert.ThrowsException<Exception>(() => new Person("BOUNATIROU", ""),
                "Pas d'exception a l'instanciation d'une personne avec un prenom vide");
        }

        [TestMethod]
        public void Person_Constructeur_Nom_chaineEspace_Prenom_Rodolphe_Exception()
        {
            Assert.ThrowsException<Exception>(() => new Person(" ", "Rodolphe"),
                "Pas d'exception a l'instanciation d'une personne avec un nom uniquement composé d'espace");
        }

        [TestMethod]
        public void Person_Constructeur_Nom_BOUNATIROU_Prenom_chaineEspace_Exception()
        {
            Assert.ThrowsException<Exception>(() => new Person("BOUNATIROU", " "),
                "Pas d'exception a l'instanciation d'une personne avec un prenom uniquement composé d'espace");
        }
    }
}