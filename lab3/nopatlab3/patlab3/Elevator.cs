using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patlab3
{
    internal class Elevator
    {
        private string _state;
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
            _state = "Waiting";
        }
        public void CallFloor(int floor)
        {
            if (_state == "Waiting")
            {
                Random rnd = new Random();
                while (CurrentFloor != floor)
                {
                    if (rnd.NextDouble() < OutageChance)
                    {
                        _state = "Waiting";
                        return;
                    }
                    if (CurrentFloor > floor)
                        CurrentFloor--;
                    else
                        CurrentFloor++;
                }
            }
        }
        public void Load(int weight)
        {
            if (_state == "Waiting")
            {
                CurrentWeight += weight;
                if (CurrentWeight > MaxWeight)
                    _state = "Overloaded";
            }
            else if (_state == "Overloaded")
                CurrentWeight += weight;
        }
        public int Unload(int weight)
        {
            if (_state == "Waiting")
            {
                if (CurrentWeight - weight < 0)
                {
                    int left = CurrentWeight;
                    CurrentWeight = 0;
                    return left;
                }
                else
                {
                    CurrentWeight -= weight;
                    return weight;
                }
            }
            if (_state == "Overloaded")
            {
                if (CurrentWeight - weight < 0)
                {
                    int left = CurrentWeight;
                    CurrentWeight = 0;
                    _state = "Waiting";
                    return left;
                }
                else
                {
                    CurrentWeight -= weight;
                    if (CurrentWeight < MaxWeight)
                        _state = "Waiting";
                    return weight;
                }
            }
            return 0;
        }
        public void RestorePower()
        {
            if (_state == "Disabled")
                _state = "Waiting";
        }
    }
}
