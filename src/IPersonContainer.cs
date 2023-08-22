using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    public interface IPersonContainer
    {
        public List<Person> SortByLastName();
        public List<Person> SortByFirstName();
    }
}
