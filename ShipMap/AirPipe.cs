using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipMap
{
    public class AirPipe : Communication
    {
        protected override Communication GetBottomCommunication()
        {
            throw new NotImplementedException();
        }

        protected override Communication GetLeftCommunication()
        {
            throw new NotImplementedException();
        }

        protected override Communication GetRightCommunication()
        {
            throw new NotImplementedException();
        }

        protected override Communication GetTopCommunication()
        {
            throw new NotImplementedException();
        }
    }
}
