namespace ConsoleApp1.ValueObjects
{
    public class Name
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName.Trim();
            LastName = lastName.Trim();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString() => $"{this.FirstName} {this.LastName}";

        public static implicit operator string(Name model) => model.ToString();
    }
}
