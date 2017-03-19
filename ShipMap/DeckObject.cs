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

        public int Height;

        public int Width;

        public bool isReflectedbyX;

        public bool isReflectedbyY;

        public RotateAngle Rotate;

        public DeckObject(ShipMap map, int x, int y) : base(map, x, y)
        {

        }

        public bool isGasPenetration(ShipMapCell cell)
        {
            return false;
        }

        public bool isPassable(ShipMapCell cell)
        {
            return false;
        }
    }
}
