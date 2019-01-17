using System.Collections.Generic;

namespace WorkflowEngine
{
	public class WorkflowEngine
	{
		public void Run(IWorkflow workflow)
		{
			foreach (var task in workflow.GetWorkflow())
			{
				task.Execute();
			}
		}
	}
}
