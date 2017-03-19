using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipMap
{
    public class Cable : Communication
    {
        public Cable(ShipMap map, int x, int y) : base(map, x, y)
        {
        }

        protected override ShipElement GetShipElement(ShipMapCell cell)
        {
            return cell.StandCable;
        }

        protected override void SetShipElement(ShipMapCell cell, ShipElement element)
        {
            cell.StandCable = (Cable)element;
        }
    }
}
