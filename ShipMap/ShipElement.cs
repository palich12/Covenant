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

        public bool IsSetup { get; private set; }

        protected ShipMap Map { get; set; }
        public int X { get; private set; }
        public int Y { get; private set; }

        private int _Height { get; set; } 
        public int Height
        {
            get
            {
                return Rotate == RotateAngle.angle0 || Rotate == RotateAngle.angle180 ? _Height : _Width;
            }
        }

        private int _Width { get; set; }
        public int Width
        {
            get
            {
                return Rotate == RotateAngle.angle0 || Rotate == RotateAngle.angle180 ? _Width : _Height;
            }
        }

        public bool IsReflectedByX { get; private set; }

        public bool IsReflectedByY { get; private set; }

        public RotateAngle Rotate { get; private set; }

        public ShipElement( ShipMap map, int width, int height)
        {
            if( map == null)
            {
                throw (new Exception("Can't create ShipElement without ShipMap"));
            }
            Map = map;
            _Width = width;
            _Height = height;

        }

        protected abstract ShipElement GetShipElement(ShipMapCell cell);

        protected abstract void SetShipElement(ShipMapCell cell, ShipElement element);

        public bool Setup(int x, int y, RotateAngle rotate, bool isreflectedbyx, bool isreflectedbyy)
        {
            X = x;
            Y = y;
            IsReflectedByX = isreflectedbyx;
            IsReflectedByY = isreflectedbyy;
            Rotate = rotate;

            if (x < 0 || y < 0 || Map.Width <= X + Width || Map.Heigth <= Y + Height)
                return false;

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    if (GetShipElement(Map.GetCell(X + i, Y + j)) != null)
                        return false;
                }
            }

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    SetShipElement(Map.GetCell(X + i, Y + j), this);
                }
            }
            return true;
        }

        public virtual void Remove()
        {
            IsSetup = false;
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    SetShipElement(Map.GetCell(X+i, Y+j), null);
                }
            }
        }
    }
}
