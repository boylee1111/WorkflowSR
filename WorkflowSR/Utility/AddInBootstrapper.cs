using Autofac;
using NLog;
using WorkflowSR.Service.Service;
using WorkflowSR.View;
using WorkflowSR.ViewModel;

namespace WorkflowSR.Utility
{
    public class AddInBootstrapper
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public IContainer InitilizeContainer()
        {
            logger.Info("Boot strapper Initialize begin.");

            var builder = new ContainerBuilder();

            builder.RegisterType<CategorySettingWindow>().InstancePerLifetimeScope();
            builder.RegisterType<ArchiveSettingWindow>().InstancePerLifetimeScope();

            builder.RegisterType<WorkflowViewModel>().InstancePerLifetimeScope();
            builder.RegisterType<CategorySettingWindowViewModel>().InstancePerLifetimeScope();
            builder.RegisterType<ArchiveSettingWindowViewModel>().InstancePerLifetimeScope();

            builder.RegisterType<WorkflowService>().As<IWorkflowService>().InstancePerLifetimeScope();

            var container = builder.Build();

            logger.Info("Boot strapper Initialize end.");

            return container;
        }
    }
}
