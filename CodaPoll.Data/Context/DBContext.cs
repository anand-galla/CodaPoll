using CodaPoll.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodaPoll.Data.Context
{
    public class DBContext : DbContext
    {
        public DBContext()
        {
            Database.SetInitializer<DBContext>(new DropCreateDatabaseIfModelChanges<DBContext>());
        }

        public DbSet<DBHacker> Hackers { get; set; }

        public DbSet<DBHackerPollParticipant> HackerPollParticipants { get; set; }
    }
}
