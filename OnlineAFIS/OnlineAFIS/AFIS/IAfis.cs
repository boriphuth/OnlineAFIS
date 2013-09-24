using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SourceAFIS.Simple;

namespace OnlineAFIS.AFIS
{
    interface IAfis
    {
        void Extract(Person person);
        IEnumerable<Person> Identify(Person probe, IEnumerable<Person> candidates);
        float Verify(Person probe, Person candidate);
    }
}