namespace DesignPatternExample.Chain_of_Responsibility.After
{
    public class ErrorLogger : Logger
    {
        public ErrorLogger(int logLevel) : base(logLevel)
        {
        }

        public override string Write(string msg)
        {
            return "Error : " + msg;
        }
    }
}
