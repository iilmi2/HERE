using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrainWatchSystem.Entities;

namespace TrainWatchSystem.DAL
{
    internal class TrainWatchContext : DbContext
    {
        public TrainWatchContext(DbContextOptions<TrainWatchContext> options) : base(options)
        {

        }
        public DbSet<DbVersion> DbVersions => Set<DbVersion>();
    }
}
