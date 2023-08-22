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


    }
}
