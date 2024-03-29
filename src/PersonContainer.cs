﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace src
{
    public class PersonContainer : IPersonContainer
    {
        private List<Person> persons;

        public List<Person> Persons { get => persons;}

        public PersonContainer()
        {
            persons = new List<Person>();
        }
        public PersonContainer(List<Person> initialPersons)
        {
            bool exist = false;
            int i = 0;
            persons = new List<Person>();
            while (i < initialPersons.Count() && !exist)
            {
                Person p = initialPersons[i];
                exist = Exists(p.Nom, p.Prenom);
                if (!exist)
                    persons.Add(p);
                i++;
            }
            if (exist)
                throw new Exception("Erreur duplicata en entrée");
        }

        public PersonContainer(params Person[] persons) : this(persons.ToList())
        {
        }

        public bool AjouterPersonne(Person person)
        {
            if (person == null || Exists(person.Nom, person.Prenom))
                return false;
            persons.Add(person);
            return true;
        }

        public bool AjouterPersonne(string nom, string prenom)
        {
            if (nom == null || nom.Trim().Equals("") || prenom == null || prenom.Trim().Equals(""))
                return false;
            return AjouterPersonne(new Person(nom,prenom));
        }

        private bool Exists(string nom, string prenom)
        {
            Person? p = persons.FirstOrDefault(d =>
            d.Nom.ToLower().Equals(nom.ToLower()) &&
            d.Prenom.ToLower().Equals(prenom.ToLower()));
            return p != default(Person);

        }      
        
        public List<Person> SortByFirstName()
        {
            this.persons.Sort((a,b)=>a.Prenom.CompareTo(b.Prenom));
            return persons;
        }

        public List<Person> SortByLastName()
        {
            this.persons.Sort((a, b) => a.Nom.CompareTo(b.Nom));
            return persons;
        }

        public string ExportToJSON()
        {
            return JsonSerializer.Serialize(persons);
        }
    }
}
