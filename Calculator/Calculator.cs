using WorkWithInterfaces.Calculator.Interfaces;
using WorkWithInterfaces.Calculator.Properties;
using WorkWithInterfaces.Calculator.Exceptions;

namespace WorkWithInterfaces.Calculator
{
    public class Calculator : ISummation, IValidator
    {

        #region Fields
        private ILogger _logger;
        #endregion Fields

        #region Constructors
        public Calculator(ILogger logger) =>
            _logger = logger;
        #endregion Constructors

        #region Methods
        public void Sum()
        {
            _logger.Event(Resources.SumEventStarted);

            Int32 a = Validate(
                String.Format(
                    Resources.EnterNSummand,
                    Resources.First));
            Int32 b = Validate(
                String.Format(
                    Resources.EnterNSummand,
                    Resources.Second));

            Console.WriteLine(
                String.Format(Resources.Result, a, b, a + b));

            _logger.Event(Resources.SumEventFinished);

            Console.ReadLine();
        }

        public Int32 Validate(String promptMessage)
        {
            Boolean isValid = false;
            Int32 validInput = 0;

            while (!isValid)
            {
                try
                {
                    Console.WriteLine(promptMessage);

                    if (Int32.TryParse(Console.ReadLine(), out validInput))
                    {
                        return validInput;
                    }
                    else
                    {
                        throw new IncorrectInputException();
                    }
                }
                catch (Exception ex)
                {
                    _logger.Error(
                        String.Format(
                            Resources.Error,
                            ex.Message));
                }
            }

            return validInput;
        }
        #endregion Methods
    }
}
