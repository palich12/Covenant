using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipMap
{
    public class AirPipe : Communication
    {
        public AirPipe(ShipMap map, int x, int y) : base(map, x, y)
        {
        }

        public override void Destroy()
        {
            throw new NotImplementedException();
        }

        protected override ShipElement GetShipElement(ShipMapCell cell)
        {
            return cell.StandAirPipe;
        }

        protected override void SetShipElement(ShipMapCell cell, ShipElement element)
        {
            cell.StandAirPipe = (AirPipe)element;
        }
    }
}
