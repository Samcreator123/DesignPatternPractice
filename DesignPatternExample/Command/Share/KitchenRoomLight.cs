using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Command.Share
{
    /// <summary>
    /// command的Reciever
    /// </summary>
    public class KitchenRoomLight : ILight
    {
        public string Off()
        {
            return "KitchenRoomLight is Off";
        }

        public string On()
        {
            return "KitchenRoomLight is On";
        }
    }
}
