using DesignPatternExample.Proxy.Share;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Proxy.Before
{
    /// <summary>
    /// 由於 ImageLoader 的特性，每次都要載入一次，如果是相同圖片會耗時、耗內存。
    /// </summary>
    public class UseCase : IUseCase
    {
        public IEnumerable<string> Print()
        {
            yield return new ImageLoader(@"https://youtu.be/Ke7SWMCGPT0?si=L0GXmjImbkYbxZ8W").DisplayImage().msg;
            yield return new ImageLoader(@"https://youtu.be/Ke7SWMCGPT0?si=L0GXmjImbkYbxZ8W").DisplayImage().msg;

            yield return new ImageLoader(@"https://en.wikipedia.org/wiki/Proxy_pattern").DisplayImage().msg;
            yield return new ImageLoader(@"https://en.wikipedia.org/wiki/Proxy_pattern").DisplayImage().msg;

            yield return new ImageLoader(@"https://en.wikipedia.org/wiki/Proxy_pattern#Class_diagram").DisplayImage().msg;
            yield return new ImageLoader(@"https://en.wikipedia.org/wiki/Proxy_pattern#Class_diagram").DisplayImage().msg;

        }
    }
}
