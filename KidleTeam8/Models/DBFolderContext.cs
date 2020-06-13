using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace KindleTeam8.Models
{
    public class DBFolderContext: DbContext
    {
        public DBFolderContext() : base("name=DBEntityFolder")
        {

        }
        public DbSet<Files> tbFiles { get; set; }
        public DbSet<Folder> tbFolder { get; set; }
    }
}
