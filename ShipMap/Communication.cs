using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipMap
{
    abstract public class Communication : ShipElement
    {
        internal CommunicationBus Bus { get; set; }

        public Communication(ShipMap map) :base(map, 1, 1)
        {
            
        }

        public override bool Setup(Point position, RotateAngle rotate = RotateAngle.angle0, bool isreflectedbyx = false, bool isreflectedbyy = false)
        {
            if( base.Setup(position, rotate, isreflectedbyx, isreflectedbyy))
            {
                CheckConnection();
                return true;
            }
            return false;
        }

        internal Communication GetLeftCommunication()
        {
            return (Communication)GetShipElement(Map.GetCell(new Point(Position.X-1, Position.Y)));
        }
        internal Communication GetRightCommunication()
        {
            return (Communication)GetShipElement(Map.GetCell(new Point(Position.X + 1, Position.Y)));
        }
        internal Communication GetTopCommunication()
        {
            return (Communication)GetShipElement(Map.GetCell(new Point(Position.X, Position.Y -1)));
        }
        internal Communication GetBottomCommunication()
        {
            return (Communication)GetShipElement(Map.GetCell(new Point(Position.X, Position.Y + 1)));
        }

        private void ChangeBus( CommunicationBus bus )
        {
            if( Bus != null )
                Bus.Communications.Remove(this);
            if (bus == null)
                bus = new CommunicationBus();
            bus.Communications.Add(this);
            Bus = bus;
        }
        public void CheckConnection()
        {
            CheckConnectionRec(this, new CommunicationBus());
        }

        private void CheckConnectionRec(Communication com, CommunicationBus newBus)
        {
            if (com == null || newBus == null || com.Bus == newBus)
                return;

            com.ChangeBus(newBus);
            CheckConnectionRec(com.GetLeftCommunication(),   newBus);
            CheckConnectionRec(com.GetRightCommunication(),  newBus);
            CheckConnectionRec(com.GetTopCommunication(),    newBus);
            CheckConnectionRec(com.GetBottomCommunication(), newBus);
        }

        public override void Remove()
        {
            base.Remove();
            CheckConnectionRec(this.GetLeftCommunication(),   new CommunicationBus());
            CheckConnectionRec(this.GetRightCommunication(),  new CommunicationBus());
            CheckConnectionRec(this.GetTopCommunication(),    new CommunicationBus());
            CheckConnectionRec(this.GetBottomCommunication(), new CommunicationBus());
        }
    }
}
