using System;

namespace WorkflowEngine
{
	public class ChangeVideoStatus : IWorkflow
	{
		public void Execute()
		{
			Console.WriteLine("Status of the video was changed to \"Processing\".");
		}
	}
}
