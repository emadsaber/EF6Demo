using DAL.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Context
{
    public class SchoolDataContext:DbContext
    {
        public SchoolDataContext() : base("name=School.Dev")
        {
            Database.SetInitializer<SchoolDataContext>(new DropCreateDatabaseIfModelChanges<SchoolDataContext>());
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }
    }
}
