using System;

namespace WorkflowEngine
{
	public class EncodeVideo : IWorkflow
	{
		public void Execute()
		{
			Console.WriteLine("Video is being encoded with third-party service.");
		}
	}
}
