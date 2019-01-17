using System;

namespace WorkflowEngine
{
	public class TaskChangeVideoStatus : ITask
	{
		public void Execute()
		{
			Console.WriteLine("Status of the video was changed to \"Processing\".");
		}
	}
}
