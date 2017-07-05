using System.Collections.Generic;

namespace PersonRepository.Interface
{
    /// <summary>
    /// CRUD repository interface
    /// </summary>
    public interface IPersonRepository
    {
        //each of the classess that implement IEnumerable<Person> can be returned
        //as a result of the method
        IEnumerable<Person> GetPeople();

        Person GetPerson(string lastName);

        void AddPerson(Person newPerson);

        void UpdatePerson(string lastName, Person updatedPerson);

        void DeletePerson(string lastName);

        void UpdatePeople(IEnumerable<Person> updatedPeople);
    }
}
