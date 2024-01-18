namespace DesignPatternExample.Chain_of_Responsibility.Before
{
    public class Logger
    {
        public static string WriteLog(int logLevel, string msg) => logLevel switch
        {
            0 => "ERROR MSG : " + msg,
            1=> "WARNING MSG : " + msg,
            2 => "INFO MSG : " + msg,
            3 => "DEBUG MSG : " + msg,
            _ => throw new Exception("no level like this"),
        };
    }
}
