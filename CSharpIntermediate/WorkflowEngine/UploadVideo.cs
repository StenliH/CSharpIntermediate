using System;

namespace WorkflowEngine
{
	public class UploadVideo : IWorkflow
	{
		public void Execute()
		{
			Console.WriteLine("Video is uploaded to the cloud storage.");
		}
	}
}
