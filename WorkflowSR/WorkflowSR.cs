using Microsoft.Office.Tools.Ribbon;
using WorkflowSR.View;

namespace WorkflowSR
{
    public partial class WorkflowSR
    {
        private void WorkflowSR_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void CategoryOption_Click(object sender, RibbonControlEventArgs e)
        {
            ArchiveSettingWindow archiveSettingWindow = new ArchiveSettingWindow();
        }

        private void ArchiveOption_Click(object sender, RibbonControlEventArgs e)
        {
            CategorySettingWindow categorySettingWindows = new CategorySettingWindow();
        }
    }
}
