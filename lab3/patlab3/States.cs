using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patlab3
{
    internal class Waiting: IElevState
    {
        public void CallFloor(int floor, Elevator e)
        {
            Random rnd = new Random();
            while (e.CurrentFloor != floor)
            {
                if (rnd.NextDouble() < e.OutageChance)
                {
                    e.ChangeState(new Disabled());
                    return;
                }
                if (e.CurrentFloor > floor)
                    e.CurrentFloor--;
                else
                    e.CurrentFloor++;
            }
        }
        public void Load(int weight, Elevator e)
        {
            e.CurrentWeight += weight;
            if (e.CurrentWeight > e.MaxWeight)
                e.ChangeState(new Overloaded());
        }
        public int Unload(int weight, Elevator e)
        {
            if (e.CurrentWeight - weight < 0)
            {
                int left = e.CurrentWeight;
                e.CurrentWeight = 0;
                return left;
            }
            else
            {
                e.CurrentWeight -= weight;
                return weight;
            }
        }
        public void RestorePower(Elevator e) { }
    }

    internal class Overloaded: IElevState
    {
        public void CallFloor(int floor, Elevator e) { }
        public void Load(int weight, Elevator e)
        {
            e.CurrentWeight += weight;
        }
        public int Unload(int weight, Elevator e)
        {
            if (e.CurrentWeight - weight < 0)
            {
                int left = e.CurrentWeight;
                e.CurrentWeight = 0;
                e.ChangeState(new Waiting());
                return left;
            }
            else
            {
                e.CurrentWeight -= weight;
                if (e.CurrentWeight < e.MaxWeight)
                    e.ChangeState(new Waiting());
                return weight;
            }
        }
        public void RestorePower(Elevator e) { }
    }

    internal class Disabled : IElevState
    {
        public void CallFloor(int floor, Elevator e) { }
        public void Load(int weight, Elevator e) { }
        public int Unload(int weight, Elevator e) { return 0; }
        public void RestorePower(Elevator e)
        {
            e.ChangeState(new Waiting());
        }
    }
}
