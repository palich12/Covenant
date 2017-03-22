using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipMap
{
    class Ventipane : DeckObject
    {
        public Ventipane(ShipMap map) : base(map, 1, 1)
        {
            Ports.Add(new AirPipePort(0, 0));
        }
    }
}
