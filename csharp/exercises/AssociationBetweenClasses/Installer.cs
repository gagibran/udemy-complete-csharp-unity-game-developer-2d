namespace AssociationBetweenClasses
{
    public class Installer
    {
        private readonly Logger _logger;

        public Installer(Logger logger)
        {
            _logger = logger;
        }
        public void Install(string appName)
        {
            _logger.Log($"Installing the application \"{appName}\"");
        }
    }
}
