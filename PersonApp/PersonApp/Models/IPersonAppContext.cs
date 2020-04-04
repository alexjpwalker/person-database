﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PersonApp.Models
{
    public interface IPersonAppContext
    {
        IDbSet<PersonGroup> PersonGroups { get; }
        IDbSet<Person> People { get; }
    }
}