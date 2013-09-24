using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace OnlineAFIS.Models
{
    public class PersonRepository : IRepository<PersonModel>
    {
        ObservableCollection<PersonModel> ocPersons = null;

        public PersonRepository()
        {
            ocPersons = GeneratePersons();
        }

        private ObservableCollection<PersonModel> GeneratePersons()
        {
            ObservableCollection<PersonModel> Persons = new ObservableCollection<PersonModel>()
            {
                new PersonModel()
                {
                    Name = "SAFE",Id =1,Fingerprints  = new List<SourceAFIS.Simple.Fingerprint>()
                }
            };
            return Persons;
        }

        private int GetLatestIdPlusOne()
        {
            int BiggestId = 0;
            foreach (PersonModel person in ocPersons)
            {
                if (BiggestId < person.Id)
                {
                    BiggestId = person.Id;
                }
            }
            return (BiggestId + 1);
        }

        public IEnumerable<PersonModel> GetAll()
        {
            return ocPersons;
        }

        public PersonModel GetById(int id)
        {
            PersonModel person = null;
            try
            {
                person = (from p in ocPersons
                              where p.Id == id
                              select p).FirstOrDefault();
            }
            catch(Exception)
            {
            
            }            
            return person;
        }

        public bool Insert(PersonModel person)
        {
            bool ret = false;
            try
            {
                person.Id = GetLatestIdPlusOne();
                ocPersons.Add(person);
                ret = true;
            }
            catch (Exception)
            {
                ret = false;
            }
            return ret;
        }

        public bool Update(PersonModel person)
        {
            bool ret = false;
            try
            {
                this.Delete(person);
                ocPersons.Add(person);
                ret = true;
            }
            catch (Exception)
            {
                ret = false;
            }
            return ret;
        }

        public bool Delete(PersonModel person)
        {
            bool ret = false;
            try
            {
                PersonModel personToRemove = GetById(person.Id);
                ocPersons.Remove(personToRemove);
                ret = true;
            }
            catch (Exception)
            {
                ret = false;
            }
            return ret;
        }
    }
}