namespace DesignPatternExample.Chain_of_Responsibility.Before
{
    /// <summary>
    /// 使用switch做分別如果越來越長 則會使閱讀性下降
    /// 並且每一個LogLevel要做的事情變多，也會需要重構
    /// </summary>
    public class UseCase : IUseCase
    {
        public IEnumerable<string> Print()
        {
            yield return Logger.WriteLog(0, "hi");
            yield return Logger.WriteLog(0, "hi");
            yield return Logger.WriteLog(1, "hi");
            yield return Logger.WriteLog(3, "hi");
        }
    }
}
