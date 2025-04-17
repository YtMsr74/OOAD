using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patlab3
{
    internal interface IElevState
    {
        void CallFloor(int floor, Elevator e);
        void Load(int weight, Elevator e);
        int Unload(int weight, Elevator e);
        void RestorePower(Elevator e);
    }
}
