using SourceAFIS.Simple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineAFIS.AFIS
{
    public class Afis : IAfis
    {
        private Afis _instance;

        // Lock synchronization object
        private static object syncLock = new object();

        // Constructor (protected)
        public Afis()
        {
            if (_instance == null)
            {
                lock (syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new Afis();
                    }
                }
            }
        }

        public void Extract(Person person)
        { 
        
        }

        public List<Person> Identify(Person probe, List<Person> candidates)
        {
            List<Person> ListPerson = new List<Person>();


            return ListPerson;
        }

        public float Verify(Person probe, Person candidate)
        {
            float verifyScore = 0;

            return verifyScore;
        }
    }
}