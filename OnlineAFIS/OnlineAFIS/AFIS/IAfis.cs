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
        List<Person> Identify(Person probe, List<Person> candidates);
        float Verify(Person probe, Person candidate);
    }
}