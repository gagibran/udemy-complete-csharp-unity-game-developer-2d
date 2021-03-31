using System;

namespace Polymorphism
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }
        public bool IsConnected { get; set; }

        public DbConnection(string connectionString, TimeSpan timeout)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentNullException("The connection string cannot be null, empty or be composed of only whitespace.");
            }
            ConnectionString = connectionString;
            Timeout = timeout;
            IsConnected = false;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}
