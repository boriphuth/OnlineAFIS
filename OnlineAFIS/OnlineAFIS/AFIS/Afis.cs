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

        public int Dpi { get; set; }

        public int MinMatches { get; set; }

        public float Threshold { get; set; }

        // Constructor (protected)
        public Afis()
        {
            if (_instance == null)
            {
                lock (this)
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

        public IEnumerable<Person> Identify(Person probe, IEnumerable<Person> candidates)
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