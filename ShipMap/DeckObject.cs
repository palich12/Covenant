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
    public class DeckObject : ShipElement
    {
        public int X;

        public int Y;

        public int Height;

        public int Width;

        public bool isReflectedbyX;

        public bool isReflectedbyY;

        public RotateAngle Rotate;

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
