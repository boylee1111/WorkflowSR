using Autofac;
using Microsoft.Office.Tools.Ribbon;
using NLog;
using WorkflowSR.View;

namespace WorkflowSR
{
    public partial class WorkflowSR
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        private void WorkflowSR_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void CategoryOption_Click(object sender, RibbonControlEventArgs e)
        {
            var categorySettingWindow = Globals.ThisAddIn.Container.Resolve<CategorySettingWindow>();
            categorySettingWindow.ShowDialog();
        }

        private void ArchiveOption_Click(object sender, RibbonControlEventArgs e)
        {
            var archiveSettingWindow = Globals.ThisAddIn.Container.Resolve<ArchiveSettingWindow>();
            archiveSettingWindow.ShowDialog();
        }
    }
}
