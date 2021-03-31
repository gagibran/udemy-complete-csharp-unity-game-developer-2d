using System;

namespace Polymorphism
{
    public class DbCommand
    {

        public string Instruction { get; set; }
        public DbConnection Database { get; set; }


        public DbCommand(string instruction, DbConnection database)
        {
            if (string.IsNullOrWhiteSpace(instruction))
            {
                throw new ArgumentNullException("The instruction cannot be null, empty or be composed of only whitespace.");
            }
            Instruction = instruction;
            Database = database;
        }

        public void Execute()
        {
            Database.OpenConnection();
            Console.WriteLine($"Executing the command \"{Instruction}\" on the database at {Database.ConnectionString}.");
            Database.CloseConnection();
        }
    }
}
