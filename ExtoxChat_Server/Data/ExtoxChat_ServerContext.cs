using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExtoxChat_Server.Models;

namespace ExtoxChat_Server.Data
{
    public class ExtoxChat_ServerContext : DbContext
    {
        public ExtoxChat_ServerContext (DbContextOptions<ExtoxChat_ServerContext> options)
            : base(options)
        {
        }

        public DbSet<ExtoxChat_Server.Models.Message> Message { get; set; }
    }
}
