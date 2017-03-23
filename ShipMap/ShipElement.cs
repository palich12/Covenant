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
        public Point Position { get; private set; }

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

        public virtual bool CheckSetupPossible(
            Point position,
            RotateAngle rotate = RotateAngle.angle0,
            bool isreflectedbyx = false,
            bool isreflectedbyy = false)
        {
            if (position.X < 0 || position.Y < 0 || Map.Width <= position.X + Width || Map.Heigth <= position.Y + Height)
                return false;

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    if (GetShipElement(Map.GetCell(new Point( position.X + i, position.Y + j))) != null)
                        return false;
                }
            }
            return true;
        }

        public virtual bool Setup(
            Point position,
            RotateAngle rotate = RotateAngle.angle0, 
            bool isreflectedbyx = false, 
            bool isreflectedbyy = false)
        {
            if(! CheckSetupPossible(position, rotate, isreflectedbyx, isreflectedbyy))
            {
                return false;
            }

            Position = position;
            IsReflectedByX = isreflectedbyx;
            IsReflectedByY = isreflectedbyy;
            Rotate = rotate;


            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    SetShipElement(Map.GetCell(new Point( Position.X + i, Position.Y + j)), this);
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
                    SetShipElement(Map.GetCell(new Point( Position.X +i, Position.Y +j)), null);
                }
            }
        }
    }
}
