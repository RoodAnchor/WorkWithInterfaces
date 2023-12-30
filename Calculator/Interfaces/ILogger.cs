namespace WorkWithInterfaces.Calculator.Interfaces
{
    public interface ILogger
    {
        public void Event(String message);
        public void Error(String message);
    }
}
