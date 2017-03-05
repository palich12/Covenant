using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipMap
{
    abstract public class Communication : ShipElement
    {
        abstract protected Communication GetLeftCommunication();
        abstract protected Communication GetRightCommunication();
        abstract protected Communication GetTopCommunication();
        abstract protected Communication GetBottomCommunication();


    }
}
