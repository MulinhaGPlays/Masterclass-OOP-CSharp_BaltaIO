using ConsoleApp1.Exceptions;
using System.Text.RegularExpressions;

namespace ConsoleApp1.ValueObjects
{
    public class Email
    {
        private readonly Regex EmailRegexPattern = new(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

        public Email(string address)
        {
            Address = address.Trim().ToLower();
            if (!EmailRegexPattern.IsMatch(Address))
                throw new InvalidEmailException($"E-mail {Address} inválido");
        }

        public string Address { get; private set; }
    }
}
