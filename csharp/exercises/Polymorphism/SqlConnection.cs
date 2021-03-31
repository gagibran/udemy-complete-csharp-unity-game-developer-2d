using System;

namespace Polymorphism
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString, TimeSpan timeout) : base(connectionString, timeout)
        {
        }

        public override void CloseConnection()
        {
            if (!IsConnected)
            {
                throw new InvalidOperationException("The connection is already closed.");
            }
            Console.WriteLine($"Disconnecting from \"{ConnectionString}\" in SQL Server.");
            IsConnected = false;
        }

        public override void OpenConnection()
        {
            if (IsConnected)
            {
                throw new InvalidOperationException("The connection is already opened.");
            }
            Console.WriteLine($"Connecting to \"{ConnectionString}\" in SQL Server. Trying for {Timeout.ToString("ss")} s...");
            IsConnected = true;
        }
    }
}
