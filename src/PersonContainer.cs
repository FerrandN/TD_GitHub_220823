using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    public class PersonContainer : IPersonContainer
    {
        List<Person> persons;

        public PersonContainer(List<Person> initialPersons)
        {

        }
        public List<Person> SortByFirstName()
        {
            throw new NotImplementedException();
        }

        public List<Person> SortByLastName()
        {
            throw new NotImplementedException();
        }
    }
}
