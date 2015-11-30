using System;

namespace WorkflowSR.Service
{
    public interface IWorkflowService
    {
        void Category();
        void Archive();
    }

    class WorkflowService : IWorkflowService
    {
        public void Archive()
        {
            throw new NotImplementedException();
        }

        public void Category()
        {
            throw new NotImplementedException();
        }
    }
}
