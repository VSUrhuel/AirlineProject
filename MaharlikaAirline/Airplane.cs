using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaharlikaAirline
{
    internal class Airplane
    {
        private String name;
        private int economyCapacity;
        private int businessClassCapacity;
        private int numBusinessClassPassesngers;
        private int numEconomyPassengers;
        private Seat[] economySeats;
        private Seat[] businessClassSeats;

        public Airplane(String name)
        {
            this.name = name;
            this.economyCapacity = 49;
            this.businessClassCapacity = 0;
            this.numEconomyPassengers = this.numBusinessClassPassesngers = 0;
            this.economySeats = new Seat[this.economyCapacity];
            this.businessClassSeats = new Seat[this.businessClassCapacity];
            int k = 0;
            for (int i=1; i<=this.economyCapacity/7; i++)
            {
                for(int j=0; j<7; j++)
                {
                    this.economySeats[k++] = new Seat(i + "" + Convert.ToChar('A' + j));
                }
            }
        }
        public void SetEconomyCapacity(int capacity) 
        { 
            if((this.numEconomyPassengers == 0) &&(capacity >= 49 && capacity % 7 ==0))
            {
                this.economyCapacity = capacity;
                this.economySeats = null;
                this.economySeats = new Seat[this.economyCapacity];
                int k = 0;
                for (int i = 1; i <= this.economyCapacity / 7; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        this.economySeats[k++] = new Seat(i + "" + Convert.ToChar('A' + j));
                    }
                }
            }
        }
        public void setBusinessClassCapacity(int capacity)
        {
            if((this.numBusinessClassPassesngers == 0) && (capacity >= 0 && capacity % 4 == 0))
            {
                this.businessClassCapacity = capacity;
                this.businessClassSeats = null;
                this.businessClassSeats = new Seat[this.businessClassCapacity];
                int k = 0;
                for (int i = 1; i <= this.businessClassCapacity / 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        this.economySeats[k++] = new Seat(i + "" + Convert.ToChar('W' + j));
                    }
                }
            }
        }
        public bool BookPassenger(Passenger passenger, string seatName, BookingType type)
        {
            if (type == BookingType.BusinessClass)
            {
                foreach (Seat s in businessClassSeats)
                {
                    if(s.GetName().Equals(seatName))
                    {
                        s.SetPassenger(passenger);
                        this.numBusinessClassPassesngers++;
                        return true;
                    }
                }
            }
            else
            {
                if (seatName.StartsWith("1") && !passenger.isPWD && numEconomyPassengers < economyCapacity - 7)
                    return false;
                else if (seatName.StartsWith("2") && !passenger.isPWD)
                {
                    foreach(Seat s in economySeats)
                    {
                        if(s.GetName().Equals(seatName))
                        {
                            s.SetPassenger(passenger);
                            this.numEconomyPassengers++;
                            return true;
                        }
                    }    
                }
                else if(passenger.isPWD && economyCapacity > numEconomyPassengers)
                {
                    foreach(Seat s in economySeats)
                    {
                        if(s.GetName().Equals(seatName))
                        {
                            s.SetPassenger(passenger);
                            this.numEconomyPassengers++;
                            return true;
                        }
                    }
                }
                else if(!passenger.isPWD && economyCapacity > numEconomyPassengers)
                {
                    foreach (Seat s in economySeats)
                    {
                        if (s.GetName().Equals(seatName))
                        {
                            s.SetPassenger(passenger);
                            this.numEconomyPassengers++;
                            return true;
                        }
                    }
                }
                return false;
            }
            return false;
        }
        public List<Passenger> GetAllEconomyPassengers()
        {
            List<Passenger> passengers = new List<Passenger>();
            foreach(Seat s in economySeats)
            {
                if (s.GetPassenger() != null)
                {
                    passengers.Add(s.GetPassenger());
                }
                else if (s.GetPassenger() == null)
                    passengers.Remove(s.GetPassenger());
                
            }
            return passengers;
        }
        public List<Passenger> GetAllBusinessClassPassengers()
        {
            List<Passenger> passengers = new List<Passenger>();
            foreach (Seat s in businessClassSeats)
            {
                if (s.GetPassenger() != null)
                    passengers.Add((Passenger)s.GetPassenger());
                else if (s.GetPassenger() == null)
                    passengers.Remove(s.GetPassenger());
            }
            return passengers;
        }
        public override string ToString()
        {
            string result = this.name + "\n\n";
            int ctr = 0;

            if (this.numEconomyPassengers + this.numBusinessClassPassesngers == this.economyCapacity + this.businessClassCapacity)
                result += "Fully Booked";
            else
            {
                if(businessClassCapacity > 0)
                {
                    foreach(Seat s in this.businessClassSeats)
                    {
                        result += s + " ";
                        if (++ctr % 4 == 0)
                            result += "\n";
                    }
                    result += "\n";
                }
                ctr = 0;
               
                foreach (Seat s in this.economySeats)
                {
                    result += s + "  ";
                    if (ctr % 7 == 1 || ctr % 7 == 4)
                        result += " ";
                    if (++ctr % 7 == 0)
                        result += "\n";
                }
            }
            return result;
        }
    }
}
