using System.Collections.Generic;
using WPF_CRUD.Models;
using WPF_CRUD.ViewModels;

namespace WPF_CRUD.Dal
{
    public interface IRepository
    {
        //Person
        void AddPerson(Person person);
        void DeletePerson(Person person);
        IList<Person> GetPeople();
        Person GetPerson(int idPerson);
        void UpdatePerson(Person person);
        //Profession
        void AddProfession(Profession profession);
        void DeleteProfession(Profession profession);
        IList<Profession> GetProfessions();
        Profession GetProfession(int idProfession);
        void UpdateProfession(Profession profession);
    }
}