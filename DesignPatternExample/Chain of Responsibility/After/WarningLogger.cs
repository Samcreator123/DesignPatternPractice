namespace DesignPatternExample.Chain_of_Responsibility.After
{
    internal class WarningLogger : Logger
    {
        public WarningLogger(int logLevel) : base(logLevel)
        {
        }

        public override string Write(string msg)
        {
            return "Warning : " + msg;
        }
    }
}
