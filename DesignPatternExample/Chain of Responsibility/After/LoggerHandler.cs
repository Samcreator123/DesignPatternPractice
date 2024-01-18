using System.Runtime.CompilerServices;

namespace DesignPatternExample.Chain_of_Responsibility.After
{
    public class LoggerHandler 
    {
        Logger Head;
        public LoggerHandler() 
        {
            this.BuildChain();
        }
        private void BuildChain()
        {
            Head = new ErrorLogger(0);
            Logger waring = new WarningLogger(1);
            Logger info = new InfoLogger(2);
            Logger deBug = new DebugLogger(3);

            Head.SetNextLogger(waring);
            waring.SetNextLogger(info);
            info.SetNextLogger(deBug);
            deBug.SetNextLogger(info);
        }
        public string WriteLog(int logLevel, string msg)
        {
            return Head.WriteLogByChain(logLevel, msg); 
        }
    }
}
