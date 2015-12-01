using Autofac;
using WorkflowSR.Utility;

namespace WorkflowSR
{
    public partial class ThisAddIn
    {
        private AddInBootstrapper _bootstrapper;
        public AddInBootstrapper Bootstrapper
        {
            get { return _bootstrapper; }
        }

        private IContainer _container;
        public IContainer Container
        {
            get { return _container; }
        }

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            // Note: Outlook no longer raises this event. If you have code that 
            //    must run when Outlook shuts down, see http://go.microsoft.com/fwlink/?LinkId=506785
        }

        public override void BeginInit()
        {
            _bootstrapper = new AddInBootstrapper();
            _container = _bootstrapper.InitilizeContainer();

            base.BeginInit();
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        #endregion
    }
}
