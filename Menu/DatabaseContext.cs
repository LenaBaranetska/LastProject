using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Menu
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("name = DatabaseContext")
        { 
            Database.SetInitializer<DatabaseContext> (new DBInitializer());
        }

        public virtual DbSet<Person> Persons { get; set; }


    }

    public class DBInitializer : DropCreateDatabaseAlways<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            base.Seed(context);
        }
    }
}
