using PersonTaskApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PersonTaskApp.Context
{
    public class PersonContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
    }
}