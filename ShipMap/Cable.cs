using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipMap
{
    public class Cable : Communication
    {
        public Cable(ShipMap map) : base(map)
        {
        }

        protected override ShipElement GetShipElement(ShipMapCell cell)
        {
            if (cell == null)
                return null;
            return cell.StandCable;
        }

        protected override void SetShipElement(ShipMapCell cell, ShipElement element)
        {
            cell.StandCable = (Cable)element;
        }
    }
}
