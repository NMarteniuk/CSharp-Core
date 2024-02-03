namespace R
{
    public class Person
    {
        protected int yearOfBirth;
        protected string healthInfo;
        protected string name;
        public Person(int yearOfBirth, string healthInfo, string name)
        {
            this.yearOfBirth = yearOfBirth;
            this.healthInfo = healthInfo;
            this.name = name;
        }
        public string GetHealthStatus() { return name + ": " + yearOfBirth + ". " + healthInfo; }
    }
    public class Child : Person
    {
        private string childIDNumber;
        public Child(int yearOfBirth, string healthInfo, string name, string childIDNumber) : base(yearOfBirth, healthInfo, name)
        {
            this.childIDNumber = childIDNumber;
        }
        public override string ToString()
            => $"{this.name} {this.childIDNumber}";
    }
    public class Adult : Person
    {
        private string passportNumber;
        public Adult(int yearOfBirth, string healthInfo, string name, string passportNumber) : base(yearOfBirth, healthInfo, name)
        {
            this.passportNumber = passportNumber;
        }
        public override string ToString()
            => $"{this.name} {this.passportNumber}";
    }
}
