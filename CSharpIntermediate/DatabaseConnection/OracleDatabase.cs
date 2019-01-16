using System;

namespace DatabaseConnection
{
	public class OracleDatabase : DbConnection
	{
		public OracleDatabase(string connectionString) : base(connectionString)
		{
			this.Timeout = new TimeSpan(0,0,5);
		}

		public override void Close()
		{
			Console.WriteLine("Closing connection to Oracle database.");
		}

		public override void Open()
		{
			Console.WriteLine("Opening connection to Oracle database with {0} connection string.", ConnectionString);
		}
	}
}
