namespace AssociationBetweenClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new Logger());
            var installer = new Installer(new Logger());
            dbMigrator.Migrate();
            installer.Install("VS Code");
        }
    }
}
