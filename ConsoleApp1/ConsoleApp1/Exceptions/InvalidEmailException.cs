namespace ConsoleApp1.Exceptions
{
    public class InvalidEmailException : Exception
    {
        private const  string DefaultErrorMessage = "E-mail Inválido";

        public InvalidEmailException(string message = DefaultErrorMessage) : base(message)
        {

        }
    }
}
