using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainWatchSystem.Entities;
using TrainWatchSystem.DAL;

namespace TrainWatchSystem.BLL
{
    public class TrainWatchServices
    {
        // Step 1: Define a readonly data field for the custom DbContext type
        private readonly TrainWatchContext _dbContext;

        // Step 2: Setup constructor for dependency injection for the custom DbContext type
        internal TrainWatchServices(TrainWatchContext context)
        {
            _dbContext = context;
        }

        // Step 3: Define methods to query and save instances of the entity
        public DbVersion GetDbVersion()
        {
            var query = _dbContext.DbVersions.FirstOrDefault()!;
            return query;
        }
    }
}
