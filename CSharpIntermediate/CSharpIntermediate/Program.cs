using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
	class Program
	{
		static void Main(string[] args)
		{
			var post = new Post("První post!", "Tímto postem zahajuji velké postění nás všech :)");

			Console.WriteLine();

			post.Print();

			for (int i = 0; i < 5; i++)
				post.UpVote();
			for (int i = 0; i < 3; i++)
				post.DownVote();

			post.EditDescription();
			Console.WriteLine("Zeditovaný post:");
			post.Print();
		}
	}
}
