namespace Vm
{
    class Employee
    {
        internal string _name;
        private DateTime _hiringDate;
        public Employee(string name, DateTime hiringDate)
        {
            _name = name;
            _hiringDate = hiringDate;
        }
        public int Experience()
            => DateTime.Now.Year - this._hiringDate.Year;
        public virtual void ShowInfo()
            => Console.WriteLine($"{this._name} has {this.Experience()} years of experience");
    }
    class Developer: Employee
    {
        private string _programmingLanguage;
        public Developer(string name, DateTime hiringDate, string programmingLanguage): base(name, hiringDate)
        {
            _programmingLanguage = programmingLanguage;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"{this._name} is {this._programmingLanguage} programmer");
        }
    }
    class Tester: Employee
    {
        private bool _isAuthomation;
        public Tester(string name, DateTime hiringDate, bool isAuthomation): base(name, hiringDate)
        {
            _isAuthomation = isAuthomation;
        }
        public override void ShowInfo()
        {
            if (_isAuthomation)
            {
                Console.WriteLine($"{this._name} is authomated tester and has {this.Experience()} year(s) of experience");
            }
            else
            {
                Console.WriteLine($"{this._name} is manual tester and has {this.Experience()} year(s) of experience");
            }
        }
    }
}
