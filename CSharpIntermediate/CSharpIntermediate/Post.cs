using System;

namespace CSharpIntermediate
{
	public class Post
	{
		public string Title { get; set; }
		public string Description { get; private set; }
		public DateTime WhenCreated { get; private set; }
		public int Votes { get; private set; }

		public Post(string title, string description)
		{
			this.Title = title;
			this.Description = description;
			this.WhenCreated = DateTime.Now;
			this.Votes = 0;
		}

		public void UpVote()
		{
			Votes++;
		}

		public void DownVote()
		{
			Votes--;
		}

		public void EditDescription()
		{
			Console.WriteLine("Write new description:\n");
			var userInput = Console.ReadLine();
			if (!String.IsNullOrWhiteSpace(userInput))
				Description = userInput;
		}

		public void Print()
		{
			Console.WriteLine(Title);
			Console.WriteLine(Description);
			Console.WriteLine("Posted " + WhenCreated.ToString("dd.MM.yyyy HH:mm:ss"));
			Console.WriteLine("Votes: " + Votes);
		}

		public void Demo()
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
