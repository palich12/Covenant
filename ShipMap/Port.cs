using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipMap
{
    public class Port
    {
        public Point RelativePosition {get; private set;}

        public Port( Point relativeposition)
        {
            RelativePosition = relativeposition;
        }
    }
}
