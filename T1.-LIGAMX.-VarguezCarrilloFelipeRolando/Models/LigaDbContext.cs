using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace LigaMX.Models
{
    public class LigaDbContext:DbContext
    {
        public LigaDbContext():base("MyConnection")
        {

        }

        public DbSet<Liga> Ligas { get; set; }
    }
}