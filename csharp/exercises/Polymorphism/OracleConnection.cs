using System;

namespace Polymorphism
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString, TimeSpan timeout) : base(connectionString, timeout)
        {
        }

        public override void CloseConnection()
        {
            if (!IsConnected)
            {
                throw new InvalidOperationException("The connection is already closed.");
            }
            Console.WriteLine($"Disconnecting from \"{ConnectionString}\" in Oracle Database.");
            IsConnected = false;
        }

        public override void OpenConnection()
        {
            if (IsConnected)
            {
                throw new InvalidOperationException("The connection is already opened.");
            }
            Console.WriteLine($"Connecting to \"{ConnectionString}\" in Oracle Database. Trying for {Timeout.ToString("ss")} s...");
            IsConnected = true;
        }
    }
}
