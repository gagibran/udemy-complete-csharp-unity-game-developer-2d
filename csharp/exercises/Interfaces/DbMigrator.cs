using System;

namespace Interfaces
{
    public class DbMigrator
    {
        private readonly ILogger _logger;


        // Dependency injection: we specify the dependencies inside the constructor for the DbMigrator class.
        // Later we create the concrete class to deal with the dependencies:
        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo($"Migration started at {DateTime.Now}");
            // We would implement the migration here.
            _logger.LogInfo($"Migration finished at {DateTime.Now}");

        }
    }
}
