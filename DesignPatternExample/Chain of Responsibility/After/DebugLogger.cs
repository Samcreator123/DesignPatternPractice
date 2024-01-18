namespace DesignPatternExample.Chain_of_Responsibility.After
{
    internal class DebugLogger : Logger
    {
        public DebugLogger(int logLevel) : base(logLevel)
        {
        }

        public override string Write(string msg)
        {
            return "Debug : " + msg;
        }
    }
}
