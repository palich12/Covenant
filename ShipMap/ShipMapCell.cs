﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipMap
{
    public class ShipMapCell
    {
        public Point Position { get; private set; }

        public FloorTile Deck { get; set; }

        public DeckObject StandObject { get; set; }

        public Cable StandCable { get; set; }

        public AirPipe StandAirPipe { get; set; }

        public double Pressure { get; set; }


        public ShipMapCell(Point position)
        {
            Position = position;
        }

        public bool isGasPenetration()
        {
            return false;
        }

        public bool isPassable()
        {
            return false;
        }

        public int GetPrice()
        {
            int res = Deck == null ? 0 : Deck.Price;
            res += StandObject == null ? 0 : StandObject.Price;
            res += StandCable == null ? 0 : StandCable.Price;
            res += StandAirPipe == null ? 0 : StandAirPipe.Price;
            return res;
        }

        public void Clean()
        {
            if(StandObject != null)
            {
                StandObject.Remove();
            }
            if (Deck != null)
            {
                Deck.Remove();
            }
            if (StandAirPipe != null)
            {
                StandAirPipe.Remove();
            }
            if (StandCable != null)
            {
                StandCable.Remove();
            }
        }
    }
}
