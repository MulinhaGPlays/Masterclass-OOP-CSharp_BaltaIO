using ConsoleApp1.ValueObjects;

namespace ConsoleApp1
{
    public class Lead
    {
        public Lead(string firstName, string lastName)
        {
            _name = new(firstName, lastName);
            _email = new($"{_name.FirstName}{_name.LastName}@gmail.com");
        }
        public Lead(string firstName, string lastName, string email)
        {
            _name = new(firstName, lastName);
            _email = new(email);
        }

        private readonly Name _name = null!;
        private readonly Email _email = null!;

        public string Name { get => _name; }
        public string FirstName { get => _name.FirstName; }
        public string LastName { get => _name.LastName; }
        public string Email { get => _email.Address; }
        public string NormalizedEmail { get => _email.Address.ToUpper(); }

        public void ChangeName(string firstName, string lastName)
        {
            _name.FirstName = String.IsNullOrWhiteSpace(firstName) ? _name.FirstName : firstName;
            _name.LastName = String.IsNullOrWhiteSpace(lastName) ? _name.LastName : lastName;
        }       
    }

}   
