using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
	class Program
	{
		static void Main(string[] args)
		{
			var workflow = new Workflow();
			workflow.AddTask(new TaskUploadVideo());
			workflow.AddTask(new TaskEncodeVideo());
			workflow.AddTask(new TaskChangeVideoStatus());
			workflow.AddTask(new TaskMailNotification());

			var workflowEngine = new WorkflowEngine();

			workflowEngine.Run(workflow);

		}
	}
}
