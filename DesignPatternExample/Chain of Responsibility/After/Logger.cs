namespace DesignPatternExample.Chain_of_Responsibility.After
{
    public abstract class Logger
    {
        protected int _logLevel;
        protected Logger _nextLogger;

        public Logger(int logLevel)
        { 
            this._logLevel = logLevel;
        }

        public void SetNextLogger(Logger logger)
        {
            this._nextLogger = logger;
        }

        public string WriteLogByChain(int logLevel, string msg)
        {
            if (logLevel > this._logLevel)
            {
                return _nextLogger.WriteLogByChain(logLevel, msg);
            }

            return this.Write(msg);
        }

        public abstract string Write(string msg);
    }
}
