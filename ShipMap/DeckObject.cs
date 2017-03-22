using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum RotateAngle : int
{
    angle0 = 0,
    angle90 = 90,
    angle180 = 180,
    angle270 = 270
}

namespace ShipMap
{
    public abstract class DeckObject : ShipElement
    {

        public List<Port> Ports { get; private set; }

        public DeckObject(ShipMap map, int width, int height) : base(map, width, height)
        {
            Ports = new List<Port>();
        }

        protected override ShipElement GetShipElement(ShipMapCell cell)
        {
            if (cell == null)
                return null;
            return cell.StandObject;
        }

        protected override void SetShipElement(ShipMapCell cell, ShipElement element)
        {
            cell.StandObject = (DeckObject)element;
        }

        public virtual bool isGasPenetration(int x, int y)
        {
            return false;
        }

        public virtual bool isPassable(int x, int y)
        {
            return false;
        }
    }
}
