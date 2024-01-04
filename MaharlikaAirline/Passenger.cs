using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaharlikaAirline
{
    internal class Passenger
    {
        private string name;
        public bool isPWD;
        
        public Passenger(string name, bool isPWD)
        {
            this.name = name;
            this.isPWD = isPWD;
        }
        public string GetName()
        {
            return this.name;
        }
        public override bool Equals(object obj)
        {
            if (((Passenger)obj).GetName().Equals(this.name))
                return true;
            return false;
        }
        public override string ToString()
        {
            string s = this.name;
            if (this.isPWD)
                s += " [P]\n";
            else
                s += "\n";
            return s;
        }
    }
}
