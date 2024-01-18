namespace DesignPatternExample.Proxy.After
{
    /// <summary>
    /// 這邊的Proxy提供一個緩存、虛擬的代理，這樣相同的url就不用重複加載
    /// 還有不同的代理模式，但就是一個Wrapper
    /// </summary>
    public class UseCase : IUseCase
    {
        public IEnumerable<string> Print()
        {
            yield return ImageProxy.DisplayImage(@"https://youtu.be/Ke7SWMCGPT0?si=L0GXmjImbkYbxZ8W").msg;
            yield return ImageProxy.DisplayImage(@"https://youtu.be/Ke7SWMCGPT0?si=L0GXmjImbkYbxZ8W").msg;

            yield return ImageProxy.DisplayImage(@"https://en.wikipedia.org/wiki/Proxy_pattern").msg;
            yield return ImageProxy.DisplayImage(@"https://en.wikipedia.org/wiki/Proxy_pattern").msg;

            yield return ImageProxy.DisplayImage(@"https://en.wikipedia.org/wiki/Proxy_pattern#Class_diagram").msg;
            yield return ImageProxy.DisplayImage(@"https://en.wikipedia.org/wiki/Proxy_pattern#Class_diagram").msg;

        }
    }
}
