using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipMap
{
    public class ShipMap
    {
        private ShipMapCell[,] Map { get; set; }

        public int Width { get; private set; }

        public int Heigth { get; private set; }

        public ShipMap(int width, int heigth)
        {
            Width = width;
            Heigth = heigth;
            Map = new ShipMapCell[width, heigth];
            for( int i = 0; i < Map.Length; i ++)
            {
                var p = new Point(i % Map.GetLength(0), i / Map.GetLength(0));
                Map[p.X, p.Y] = new ShipMapCell(p);
            }
        }

        public ShipMapCell GetCell(Point position)
        {
            if (position.X < 0 || position.Y < 0 || Map.GetLength(0) <= position.X || Map.GetLength(1) <= position.Y)
                return null;
            return Map[position.X, position.Y];
        }
        public bool CleanCell(int x, int y)
        {
            if (x < 0 || y < 0 || Map.GetLength(0) <= x || Map.GetLength(1) <= y)
                return false;
            
            return true;
        }

        internal ShipMapCell GetCell(Point point, object p)
        {
            throw new NotImplementedException();
        }
    }
}
