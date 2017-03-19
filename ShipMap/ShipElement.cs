using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipMap
{
    abstract public class ShipElement
    {
        public int Price
        {
            get;
            protected set;
        }

        public ShipMap Map { get; private set; }
        public int X { get; private set; }
        public int Y { get; private set; }

        public ShipElement( ShipMap map, int x, int y)
        {
            if( map == null)
            {
                throw (new Exception("Can't create ShipElement without ShipMap"));
            }
            Map = map;
            X = x;
            Y = y;
            if (Map.GetCell(X, Y) == null)
            {
                throw (new Exception("X or Y out of range in ShipMap"));
            }
        }

        protected abstract ShipElement GetShipElement(ShipMapCell cell);

        protected abstract void SetShipElement(ShipMapCell cell, ShipElement element);

        public virtual void Destroy()
        {
            SetShipElement(Map.GetCell(X, Y), null);
        }
    }
}
