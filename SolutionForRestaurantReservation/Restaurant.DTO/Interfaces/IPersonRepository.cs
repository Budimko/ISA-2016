using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DTO.Interfaces
{
    public interface IPersonRepository
    {
        int AddPerson(Person person);
        void UpdatePerson(Person person);
        void DeletePerson(int id);
        IEnumerable<Person> GetAllPersons();
    }
}
