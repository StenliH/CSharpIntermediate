using System;

namespace WorkflowEngine
{
	public class TaskEncodeVideo : ITask
	{
		public void Execute()
		{
			Console.WriteLine("Video is being encoded with third-party service.");
		}
	}
}
