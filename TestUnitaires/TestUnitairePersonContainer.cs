using Microsoft.VisualStudio.TestTools.UnitTesting;
using src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUnitaires
{
    [TestClass]
    public class TestUnitairePersonContainer
    {
        [TestMethod]
        public void PersonContainer_ConstructeurParDefaut_InstanceOKLongueurCollection0() {
            PersonContainer pc = new PersonContainer();
            Assert.IsTrue(pc.Persons.Count() == 0, "Il y'a deja des données");
        }

        [TestMethod]
        public void PersonContainer_ConstructeurClassiqueAvecParams_3PersonnAjouteDifferente_3PersonneALaFin()
        {
            PersonContainer pc = new PersonContainer(
                new Person("Jean", "jacques"), new Person("Jacques", "jean"), new Person("Jeanne", "arc"));
            Assert.IsTrue(pc.Persons.Count() == 3, "Pas 3 personne après ajout");
        }

        [TestMethod]
        public void PersonContainer_ConstructeurClassiqueAvecParams_2PersonneDuplicata_Exception()
        {
            Assert.ThrowsException<Exception>(()=> new PersonContainer(
                new Person("Jean", "jacques"), new Person("Jean", "jacques")), "Pas d'exception levée malgrès duplicata");
        }

        [TestMethod]
        public void PersonContainer_AjouterPersonne_ParamPersonne_PersonneNonExistante_RetourTrue_AjoutCollection()
        {
            PersonContainer pc = new PersonContainer();
            Assert.IsTrue(pc.AjouterPersonne(new Person("n", "f")), "Probleme retour false attendu true");
            Assert.AreEqual(1, pc.Persons.Count(), "Probleme longueur inchange");
        }

        [TestMethod]
        public void PersonContainer_AjouterPersonne_ParamPersonne_PersonneExistante_RetourFalse_CollectionInchange()
        {
            PersonContainer pc = new PersonContainer(new Person("n", "f"));
            Assert.IsFalse(pc.AjouterPersonne(new Person("n", "f")), "Probleme retour true attendu false");
            Assert.AreEqual(1, pc.Persons.Count(), "Probleme longueur change");
        }

        [TestMethod]
        public void PersonContainer_AjouterPersonne_ParamPersonne_Null_RetourFalse_CollectionInchange()
        {
            PersonContainer pc = new PersonContainer();
            Assert.IsFalse(pc.AjouterPersonne(null), "Probleme retour true attendu false");
            Assert.AreEqual(0, pc.Persons.Count(), "Probleme longueur change");
        }

        [TestMethod]
        public void PersonContainer_AjouterPersonne_Param2String_Spaces_Surname_RetourFalse_CollectionInchange()
        {
            PersonContainer pc = new PersonContainer();
            Assert.IsFalse(pc.AjouterPersonne("  ","f"), "Probleme retour true attendu false");
            Assert.AreEqual(0, pc.Persons.Count(), "Probleme longueur change");
        }
        [TestMethod]
        public void PersonContainer_AjouterPersonne_Param2String_Name_Spaces_RetourFalse_CollectionInchange()
        {
            PersonContainer pc = new PersonContainer();
            Assert.IsFalse(pc.AjouterPersonne("n", "  "), "Probleme retour true attendu false");
            Assert.AreEqual(0, pc.Persons.Count(), "Probleme longueur change");
        }

        [TestMethod]
        public void PersonContainer_SortByFirstName_Param3persons_RetourTrue_CollectionDansLOrdre()
        {
            PersonContainer pc = new PersonContainer();
            pc.AjouterPersonne("b", "c");
            pc.AjouterPersonne("a", "d");
            pc.AjouterPersonne("c", "a");
            List<Person> persons = pc.SortByFirstName();
            Assert.AreEqual("a", persons[0].Prenom, "probleme tri indice 0");
            Assert.AreEqual("c", persons[1].Prenom, "probleme tri indice 1");
            Assert.AreEqual("d", persons[2].Prenom, "probleme tri indice 2");
        }

        [TestMethod]
        public void PersonContainer_SortByLastName_Param3persons_RetourTrue_CollectionDansLOrdre()
        {
            PersonContainer pc = new PersonContainer();
            pc.AjouterPersonne("b", "c");
            pc.AjouterPersonne("a", "d");
            pc.AjouterPersonne("c", "a");
            List<Person> persons = pc.SortByLastName();
            Assert.AreEqual("a", persons[0].Nom, "probleme tri indice 0");
            Assert.AreEqual("b", persons[1].Nom, "probleme tri indice 1");
            Assert.AreEqual("c", persons[2].Nom, "probleme tri indice 2");
        }

        [TestMethod]
        public void PersonContainer_ExportToJSON_FormatOK()
        {
            PersonContainer pc = new PersonContainer(new Person("a", "b"));
            string rt = pc.ExportToJSON();
            string expected = "[{\"Nom\":\"a\",\"Prenom\":\"b\"}]";
            Assert.IsTrue(rt.Equals(expected),
                String.Format("({0}) différent de ({1})", rt , expected)); 
        }
    }
}
