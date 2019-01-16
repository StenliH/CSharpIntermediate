using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
	class Program
	{
		static void Main(string[] args)
		{
			var sql = new SqlConnection("SQL-23489");
			var dbCommand = new DbCommand("\"Přidej uživatele Stenli.\"", sql);
			dbCommand.Execute();

			var oracle = new OracleDatabase("Oracle-165796");
			dbCommand = new DbCommand("\"Smaž uživatele Stenli.\"", oracle);
			dbCommand.Execute();

		}
	}
}
