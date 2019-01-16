using System;

namespace WorkflowEngine
{
	public class MailNotification : IWorkflow
	{
		public void Execute()
		{
			Console.WriteLine("Mail was send to the owner of the video.");
		}
	}
}
