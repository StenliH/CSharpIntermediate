using System;

namespace DatabaseConnection
{
	public abstract class DbConnection
	{
		public string ConnectionString { get; set; }
		public TimeSpan Timeout { get; set; }

		public DbConnection(string connectionString)
		{
			if (String.IsNullOrEmpty(connectionString))
				throw new ArgumentException("connectionString", "Connection string is null or empty.");

			this.ConnectionString = connectionString;
		}

		public abstract void Open();

		public abstract void Close();
	}
}
