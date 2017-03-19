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

        public Communication(ShipMap map, int x, int y) :base(map, x, y)
        {
            CheckConnection();
        }

        internal Communication GetLeftCommunication()
        {
            return (Communication)GetShipElement(Map.GetCell(X-1,Y));
        }
        internal Communication GetRightCommunication()
        {
            return (Communication)GetShipElement(Map.GetCell(X + 1, Y));
        }
        internal Communication GetTopCommunication()
        {
            return (Communication)GetShipElement(Map.GetCell(X, Y-1));
        }
        internal Communication GetBottomCommunication()
        {
            return (Communication)GetShipElement(Map.GetCell(X, Y + 1));
        }

        public void CheckConnection()
        {
            CheckConnectionRec(this, new CommunicationBus());
        }

        private void ChangeBus( CommunicationBus bus )
        {
            Bus.Communications.Remove(this);
            bus.Communications.Add(this);
            Bus = bus;
        }

        private void CheckConnectionRec(Communication com, CommunicationBus newBus)
        {
            if (com == null)
                return;

            com.ChangeBus(newBus);
            CheckConnectionRec(com.GetLeftCommunication(),   newBus);
            CheckConnectionRec(com.GetRightCommunication(),  newBus);
            CheckConnectionRec(com.GetTopCommunication(),    newBus);
            CheckConnectionRec(com.GetBottomCommunication(), newBus);
        }

        public override void Destroy()
        {
            base.Destroy();
            CheckConnectionRec(this.GetLeftCommunication(),   new CommunicationBus());
            CheckConnectionRec(this.GetRightCommunication(),  new CommunicationBus());
            CheckConnectionRec(this.GetTopCommunication(),    new CommunicationBus());
            CheckConnectionRec(this.GetBottomCommunication(), new CommunicationBus());
        }
    }
}
