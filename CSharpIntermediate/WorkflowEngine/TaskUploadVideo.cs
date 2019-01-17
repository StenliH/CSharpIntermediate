using System;

namespace WorkflowEngine
{
	public class TaskUploadVideo : ITask
	{
		public void Execute()
		{
			Console.WriteLine("Video is uploaded to the cloud storage.");
		}
	}
}
