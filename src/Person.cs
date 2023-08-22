using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{

    public class Person
    {
        private string nom;
        private string prenom;

        public string Nom { get => nom; }
        public string Prenom {  get=> prenom; }
        public Person(string _nom, string _prenom)
        {
            if(checkIfEmpty(_nom) || checkIfEmpty(_prenom))
            {
                throw new Exception();
            }
            this.nom = _nom.Trim();
            this.prenom = _prenom.Trim();
        }

        private bool checkIfEmpty(string toTest)
        {
            return (toTest == null || toTest.Trim().Equals(""));
        }
    }
}
