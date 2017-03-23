using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipMap
{
    public class AirGenerator : DeckObject
    {
        public AirGenerator(ShipMap map) : base(map, 8, 4)
        {
            Ports.Add(new AirPipePort(new Point(0, 0)));
            Ports.Add(new CablePort( new Point( 1,0)));
        }
    }
}
