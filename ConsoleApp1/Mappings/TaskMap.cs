﻿using ConsoleApp1.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Mappings
{
    public class TaskMap : ClassMap<Task>
    {
        public TaskMap()
        {
            Id(x => x.Id);
            Map(x => x.CreationTime);
            Map(x => x.State);
            Map(x => x.Title);
            Map(x => x.Description);
            Map(x => x.UpdatedDate);
            Map(x => x.CreationDate);
            References(x => x.AssignedTo);
        }
    }
}
