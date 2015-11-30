namespace WorkflowSR.Model
{
    public class Case
    {
        private string _caseID;
        public string CaseID
        {
            get { return _caseID; }
            set { _caseID = value; }
        }

        private string _customerTitle;
        public string CustomerTitle
        {
            get { return _customerTitle; }
            set { _customerTitle = value; }
        }

        private string _engineerTitle;
        public string EngineerTitle
        {
            get { return _engineerTitle; }
            set { _engineerTitle = value; }
        }

        private string _contactName;
        public string ContactName
        {
            get { return _contactName; }
            set { _contactName = value; }
        }

        private string _contactPhone;
        public string ContactPhone
        {
            get { return _contactPhone; }
            set { _contactPhone = value; }
        }
    }
}
