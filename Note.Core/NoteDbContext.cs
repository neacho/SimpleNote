using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

using Note.Core.Entity;
namespace Note.Core
{
    public class NoteDbContext: DbContext
    {
        public DbSet<Catagory_info> Catagory { get; set; }

        public NoteDbContext() : base("NoteDbContext") { }
    }
}
