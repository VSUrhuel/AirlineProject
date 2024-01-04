using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaharlikaAirline
{
    internal class Seat
    {
        private string name;
        private Passenger passenger;

        public Seat(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return this.name;
        }
        public bool IsAvailable()
        {
            return passenger == null;
        }
        public bool SetPassenger(Passenger passenger)
        {
            if(IsAvailable())
            {
                this.passenger = passenger;
                return true;
            }
            return false;
        }
        public Passenger GetPassenger()
        {
            return this.passenger;
        }
        public override string ToString()
        {
            string text = "[";
            if (this.IsAvailable())
                text += this.name + "]";
            else
                text += "XX]";
            return text;
        }

    }
}
