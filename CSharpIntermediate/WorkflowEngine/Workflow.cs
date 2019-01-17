using System;
using System.Collections.Generic;

namespace WorkflowEngine
{
	public class Workflow : IWorkflow
	{
		readonly List<ITask> _tasks;

		public Workflow()
		{
			_tasks = new List<ITask>();
		}

		public void AddTask(ITask task)
		{
			if (task == null)
				throw new ArgumentNullException("task");

			_tasks.Add(task);
		}

		public void RemoveTask(ITask task)
		{
			_tasks.Remove(task);
		}

		public IList<ITask> GetWorkflow()
		{
			return _tasks;
		}

	}
}
