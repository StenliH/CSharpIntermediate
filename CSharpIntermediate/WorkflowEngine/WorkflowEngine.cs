using System;
using System.Collections.Generic;

namespace WorkflowEngine
{
	public class WorkflowEngine
	{
		private readonly IList<IWorkflow> _workflows;

		public WorkflowEngine()
		{
			this._workflows = new List<IWorkflow>();
		}

		public void Run()
		{
			foreach (var workflow in _workflows)
			{
				workflow.Execute();
			}
		}

		public void RegisterWorkflow(IWorkflow workflow)
		{
			_workflows.Add(workflow);
		}
	}
}
