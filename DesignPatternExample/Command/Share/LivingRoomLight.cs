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
    public class LivingRoomLight : ILight
    {
        public string Off()
        {
            return "LivingRoomLight is Off";
        }

        public string On()
        {
            return "LivingRoomLight is On";
        }
    }
}
