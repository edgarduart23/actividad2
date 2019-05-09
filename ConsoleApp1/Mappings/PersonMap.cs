using ConsoleApp1.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Mappings
{
    public class PersonMap : ClassMap<Person>
    {
        public PersonMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.CreationDate);
            Map(x => x.UpdatedDate);
        }
    }
}
