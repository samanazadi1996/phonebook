using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace phonebook.Models
{
    public class databasecontext :DbContext
    {
        static databasecontext() {
            Database.SetInitializer(new CreateDatabaseIfNotExists<databasecontext>());
        }
        public DbSet<pb> pbs { get; set; }
    }
}