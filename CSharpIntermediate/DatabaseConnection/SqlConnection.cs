using System;

namespace DatabaseConnection
{
	public class SqlConnection : DbConnection
	{
		public SqlConnection(string connectionString) : base(connectionString)
		{
			this.Timeout = new TimeSpan(0, 0, 3);
		}

		public override void Close()
		{
			Console.WriteLine("Closing connection with SQL database.");
		}

		public override void Open()
		{
			Console.WriteLine("Opening connection to SQL database with {0} connection string.", ConnectionString);
		}
	}
}
