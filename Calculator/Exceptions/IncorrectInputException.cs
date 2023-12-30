namespace WorkWithInterfaces.Calculator.Exceptions
{
    public class IncorrectInputException : Exception
    {
        public IncorrectInputException() : base(Properties.Resources.IncorrectInput) { }
    }
}
