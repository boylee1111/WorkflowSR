namespace WorkflowSR
{
    partial class WorkflowSR : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public WorkflowSR()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Office.Tools.Ribbon.RibbonDialogLauncher ribbonDialogLauncherImpl1 = this.Factory.CreateRibbonDialogLauncher();
            Microsoft.Office.Tools.Ribbon.RibbonDialogLauncher ribbonDialogLauncherImpl2 = this.Factory.CreateRibbonDialogLauncher();
            this.workflow = this.Factory.CreateRibbonTab();
            this.category = this.Factory.CreateRibbonGroup();
            this.button1 = this.Factory.CreateRibbonButton();
            this.checkBox2 = this.Factory.CreateRibbonCheckBox();
            this.archive = this.Factory.CreateRibbonGroup();
            this.button2 = this.Factory.CreateRibbonButton();
            this.checkBox1 = this.Factory.CreateRibbonCheckBox();
            this.workflow.SuspendLayout();
            this.category.SuspendLayout();
            this.archive.SuspendLayout();
            this.SuspendLayout();
            // 
            // workflow
            // 
            this.workflow.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.workflow.Groups.Add(this.category);
            this.workflow.Groups.Add(this.archive);
            this.workflow.Label = "Workflow SR";
            this.workflow.Name = "workflow";
            // 
            // category
            // 
            this.category.DialogLauncher = ribbonDialogLauncherImpl1;
            this.category.Items.Add(this.button1);
            this.category.Items.Add(this.checkBox2);
            this.category.Label = "Category";
            this.category.Name = "category";
            this.category.DialogLauncherClick += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.CategoryOption_Click);
            // 
            // button1
            // 
            this.button1.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button1.Label = "Category";
            this.button1.Name = "button1";
            this.button1.ShowImage = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Label = "Create Rule";
            this.checkBox2.Name = "checkBox2";
            // 
            // archive
            // 
            this.archive.DialogLauncher = ribbonDialogLauncherImpl2;
            this.archive.Items.Add(this.button2);
            this.archive.Items.Add(this.checkBox1);
            this.archive.Label = "Archive";
            this.archive.Name = "archive";
            this.archive.DialogLauncherClick += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ArchiveOption_Click);
            // 
            // button2
            // 
            this.button2.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button2.Label = "button2";
            this.button2.Name = "button2";
            this.button2.ShowImage = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Label = "Remove Rule";
            this.checkBox1.Name = "checkBox1";
            // 
            // WorkflowSR
            // 
            this.Name = "WorkflowSR";
            this.RibbonType = "Microsoft.Outlook.Explorer, Microsoft.Outlook.Mail.Read";
            this.Tabs.Add(this.workflow);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.WorkflowSR_Load);
            this.workflow.ResumeLayout(false);
            this.workflow.PerformLayout();
            this.category.ResumeLayout(false);
            this.category.PerformLayout();
            this.archive.ResumeLayout(false);
            this.archive.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab workflow;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup category;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup archive;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button2;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox checkBox1;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox checkBox2;
    }

    partial class ThisRibbonCollection
    {
        internal WorkflowSR WorkflowSR
        {
            get { return this.GetRibbon<WorkflowSR>(); }
        }
    }
}
