using System;

namespace WorkflowEngine
{
	public class TaskMailNotification : ITask
	{
		public void Execute()
		{
			Console.WriteLine("Mail was send to the owner of the video.");
		}
	}
}
