using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

using Note.Core.Entity;
namespace Note.Core
{
    public class FileDbContext:DbContext
    {
        public DbSet<Catagory_detail> Detail { get; set; }

        public DbSet<file_info> Files { get; set; }

        public FileDbContext() : base("NoteDbContext") { }
    }
}
