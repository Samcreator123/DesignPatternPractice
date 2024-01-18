using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Proxy.Share
{
    internal class ImageLoader
    {
        private string _url;

        public ImageLoader(string url)
        {
            this._url = url;
        }
        public (string msg, object image) DisplayImage()
        {
            //load image by url
            return ($"載入圖片 url : {_url}", new object());
        }
    }
}
