namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new ConsoleLogger()); // Completing the dependency injection.
            // var dbMigrator = new DbMigrator(new FileLogger("path/to/a/.txt")); // Also works. Also completes the dependency injection.
            dbMigrator.Migrate();
        }
    }
}
