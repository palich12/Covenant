using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipMap
{
    public class Port
    {
        public int RelativeX {get; private set;}

        public int RelativeY { get; private set; }

        public Port( int relativex, int relativey)
        {
            RelativeX = relativex;
            RelativeY = relativey;
        }
    }
}
