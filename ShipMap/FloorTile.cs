using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipMap
{
    public class FloorTile : ShipElement
    {
        public FloorTile(ShipMap map) : base(map, 1, 1)
        {
        }

        protected override ShipElement GetShipElement(ShipMapCell cell)
        {
            if (cell == null)
                return null;
            return cell.Deck;
        }

        protected override void SetShipElement(ShipMapCell cell, ShipElement element)
        {
            cell.Deck = (FloorTile)element;
        }
    }
}
