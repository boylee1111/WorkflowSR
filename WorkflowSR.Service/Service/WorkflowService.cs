using System;

namespace WorkflowSR.Service.Service
{
    public interface IWorkflowService
    {
        void Category();
        void Archive();
    }

    public class WorkflowService : IWorkflowService
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
