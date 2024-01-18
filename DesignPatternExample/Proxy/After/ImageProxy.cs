using DesignPatternExample.Proxy.Share;

namespace DesignPatternExample.Proxy.After
{
    internal class ImageProxy
    {
        private static Dictionary<string, (string msg, object image)> _imageCache = new Dictionary<string, (string msg, object image)>();

        public static (string msg, object image) DisplayImage(string url)
        {
            if (_imageCache.TryGetValue(url, out _))
            {
                string msg = "從緩存加載" + _imageCache[url].msg;
                return (msg, _imageCache[url].image);
            }

            ImageLoader imageLoader = new ImageLoader(url);

            var msgAndImagePair = imageLoader.DisplayImage();

            _imageCache.Add(url, msgAndImagePair);

            return msgAndImagePair;
        }
    }
}
