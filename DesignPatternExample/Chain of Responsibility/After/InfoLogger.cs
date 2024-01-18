namespace DesignPatternExample.Chain_of_Responsibility.After
{
    internal class InfoLogger : Logger
    {
        public InfoLogger(int logLevel) : base(logLevel)
        {
        }

        public override string Write(string msg)
        {
            return "Info : " + msg;
        }
    }
}
