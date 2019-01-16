using System;

namespace DatabaseConnection
{
	public class DbCommand
	{
		public string Instruction { get; set; }
		public DbConnection Connection { get; set; }

		public DbCommand(string instruction, DbConnection connection)
		{
			if (string.IsNullOrWhiteSpace(instruction))
				throw new ArgumentException("Database instruction is null or empty.");

			if (connection == null)
				throw new ArgumentNullException("connection");

			this.Instruction = instruction;
			this.Connection = connection;
		}

		public void Execute()
		{
			Connection.Open();
			Console.WriteLine("Instructions for the database: {0}", Instruction);
			Connection.Close();
		}
	}
}
