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
			var engine = new WorkflowEngine();
			engine.RegisterWorkflow(new UploadVideo());
			engine.RegisterWorkflow(new EncodeVideo());
			engine.RegisterWorkflow(new MailNotification());
			engine.RegisterWorkflow(new ChangeVideoStatus());

			engine.Run();

		}
	}
}
