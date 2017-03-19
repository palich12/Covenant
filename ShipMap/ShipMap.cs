using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipMap
{
    public class ShipMap
    {
        public ShipMapCell[,] Map { get; set; }

        public ShipMap(int width, int heigth)
        {
            Map = new ShipMapCell[width, heigth];
            for( int i = 0; i < Map.Length; i ++)
            {
                Map.SetValue(new ShipMapCell(), i);
            }
        }

        public ShipMapCell GetCell(int x, int y)
        {
            if (x < 0 || y < 0 || Map.GetLength(0) >= x || Map.GetLength(1) >= y)
                return null;
            return Map[x, y];
        }
    }
}
