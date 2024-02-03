namespace Am
{
    class MyAccessModifiers
    {
        private int birthYear;
        protected string personalInfo;
        private protected string IdNumber;
        public int Age
        {
            get => DateTime.Now.Year - birthYear;
            
        }
        public byte averageMiddleAge = 50;
        internal string Name { get; set; }
        public string NickName { get; internal set; }
        public MyAccessModifiers(int birthYear, string IdNumber, string personalInfo)
        {
            this.birthYear = birthYear;
            this.IdNumber = IdNumber;
            this.personalInfo = personalInfo;
        }
        public MyAccessModifiers() { }
        protected internal void HasLivedHalfOfLife() { }
        public override bool Equals(object? obj)
        {
            if ((obj == null) || this.GetType() != obj.GetType())
            {
                return false;
            }
            var myAccessModifier = (MyAccessModifiers)obj;
            return myAccessModifier.Name == Name && myAccessModifier.Age == Age && myAccessModifier.personalInfo == personalInfo;

        }
        public override int GetHashCode() 
            => HashCode.Combine(Name, Age, personalInfo);
        public static bool operator ==(MyAccessModifiers first, MyAccessModifiers second) 
            => first.Equals(second);
        public static bool operator !=(MyAccessModifiers first, MyAccessModifiers second) 
            => !first.Equals(second);
    }
}

