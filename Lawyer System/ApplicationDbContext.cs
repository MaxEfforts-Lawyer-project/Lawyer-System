using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Lawyer_System.Areas;
using Lawyer_System.Areas.sessionarea;

namespace Lawyer_System
{
    class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("Data Source=.;Initial Catalog=LawyerSystem;Integrated Security=True")
        {

        }
        public DbSet<Client> clients { get; set; }
        public DbSet<Document> documents { get; set; }
        public DbSet<Lawsuit> lawsuits { get; set; }
        public DbSet<Opponent> opponents { get; set; }
       public DbSet<session> sessions { get; set; }
        public DbSet<IDs> ides { get; set; }

    }
}
