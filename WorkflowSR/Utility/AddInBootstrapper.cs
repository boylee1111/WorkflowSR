using Autofac;
using NLog;
using WorkflowSR.Service;
using WorkflowSR.ViewModel;

namespace WorkflowSR.Utility
{
    public class AddInBootstrapper
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public void Initilize()
        {
            logger.Info("Boot strapper Initialize begin.");

            var builder = new ContainerBuilder();
            builder.RegisterType<WorkflowViewModel>().As<IWorkflowViewModel>();
            builder.RegisterType<WorkflowService>().As<IWorkflowService>();

            var container = builder.Build();

            logger.Info("Boot strapper Initialize end.");
        }
    }
}
