using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patlab3
{
    internal class Elevator
    {
        private IElevState _state;
        public int CurrentFloor;
        public int MaxWeight;
        public int CurrentWeight;
        public double OutageChance;

        public Elevator(int weight = 200, double chance = 10)
        {
            MaxWeight = weight;
            OutageChance = chance;
            CurrentFloor = 1;
            CurrentWeight = 0;
            _state = new Waiting();
        }
        public void ChangeState(IElevState state)
        {
            _state = state;
        }
        public void CallFloor(int floor)
        {
            _state.CallFloor(floor, this);
        }
        public void Load(int weight)
        {
            _state.Load(weight, this);
        }
        public int Unload(int weight)
        {
            return _state.Unload(weight, this);
        }
        public void RestorePower()
        {
            _state.RestorePower(this);
        }
    }
}
