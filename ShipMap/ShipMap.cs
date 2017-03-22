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
                int x = i % Map.GetLength(0);
                int y = i / Map.GetLength(0);
                Map[x, y] = new ShipMapCell(x,y);
            }
        }

        public ShipMapCell GetCell(int x, int y)
        {
            if (x < 0 || y < 0 || Map.GetLength(0) <= x || Map.GetLength(1) <= y)
                return null;
            return Map[x, y];
        }
        public bool CleanCell(int x, int y)
        {
            if (x < 0 || y < 0 || Map.GetLength(0) <= x || Map.GetLength(1) <= y)
                return false;
            
            return true;
        }
    }
}
