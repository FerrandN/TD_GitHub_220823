using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    public class PersonContainer : IPersonContainer
    {
        private List<Person> persons;

        public List<Person> Persons { get => persons;}

        public PersonContainer(List<Person> initialPersons)
        {
            persons = initialPersons;
        }

        public PersonContainer(params Person[] persons)
        {
            this.persons = persons.ToList();
            
        }
        public List<Person> SortByFirstName()
        {
            this.persons.Sort((a,b)=>a.Prenom.CompareTo(b.Nom));
            return persons;
        }

        public List<Person> SortByLastName()
        {
            this.persons.Sort((a, b) => a.Nom.CompareTo(b.Nom));
            return persons;
        }
    }
}
