using WorkWithInterfaces.Calculator.Interfaces;

namespace WorkWithInterfaces.Calculator
{
    public class Logger : ILogger
    {
        #region Methods
        public void Event(String message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void Error(String message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
        #endregion Methods
    }
}
