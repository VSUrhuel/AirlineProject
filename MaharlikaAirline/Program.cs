using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaharlikaAirline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Airplane a = new Airplane("FLY999");
            a.setBusinessClassCapacity(2);
            a.SetEconomyCapacity(14);
            Console.WriteLine(a);
            //Console.ReadLine();
            string[] passengerNames = { "Jayden Jimenez", "Carleigh Lowery", "Jameson Dickson", "Aliyah Case", "Kaiden Levine", "Melvin Tanner", "Mara Solomon", "Fernando Vasquez", "Solomon Diaz", "Daniel Glover", "Ariella Henderson", "Kayden Mcdonald", "Lilah Coleman", "Natalia Conner", "Vaughn Jensen", "Janet Flores", "Terrance Clay", "Kale Montgomery", "Maximillian Tran", "Mekhi Delacruz", "Mallory Perkins", "Sloane Marshall", "Osvaldo Le", "Krystal Shaw", "Annika Thomas", "Blaine Kelley", "Donna Joseph", "Steve Young", "Jaylen Juarez", "Izaiah Rogers", "Kylie Liu", "Jensen Fletcher", "Waylon Solomon", "Moriah Waller", "Raina Hill", "Miles Brock", "Sheldon Ortiz", "Cecilia Young", "Kirsten Yu", "Azaria Mcguire", "Krish Francis", "Sanai Chandler", "Shania Hooper", "Danica Jacobson", "Erica Huff", "August Ball", "Milo Hurst", "Evelin Moss", "Lea Hooper" };
            int ctr = 0;

            for (int i = 1; i <= 3; i++)
            {
                for (char c = 'V'; c < 'Z'; c++)
                {
                    a.BookPassenger(new Passenger("Jay", false), i + "" + c, BookingType.BusinessClass);
                }
            }

            for (int i = 7; i > 0; i--)
            {
                for (char c = 'A'; c < 'H'; c++)
                {
                    a.BookPassenger(new Passenger(passengerNames[ctr++], ctr % 14 == 3), i + "" + c, BookingType.Economy);
                }
            }

            a.BookPassenger(new Passenger("Karen", false), "1D", BookingType.Economy);
            a.BookPassenger(new Passenger("Mark", true), "1G", BookingType.Economy);
            a.BookPassenger(new Passenger("Devon", false), "1A", BookingType.Economy);
            Console.WriteLine(a);

            List<Passenger> pB = a.GetAllBusinessClassPassengers();
            Console.WriteLine("Business Class Passengers:");
            foreach (Passenger p in pB)
                Console.WriteLine(p);
            Console.WriteLine();

            List<Passenger> pE = a.GetAllEconomyPassengers();
            Console.WriteLine("Economy Passengers:");
            foreach (Passenger p in pE)
                Console.WriteLine(p);

            Airplane b = new Airplane("FLY999");
            b.setBusinessClassCapacity(2);
            b.SetEconomyCapacity(14);
            Console.WriteLine(a);
            String[] passengerNames1 = new String[] { "Jayden Jimenez", "Carleigh Lowery", "Jameson Dickson", "Aliyah Case", "Kaiden Levine", "Melvin Tanner", "Mara Solomon", "Fernando Vasquez", "Solomon Diaz", "Daniel Glover", "Ariella Henderson", "Kayden Mcdonald", "Lilah Coleman", "Natalia Conner", "Vaughn Jensen", "Janet Flores", "Terrance Clay", "Kale Montgomery", "Maximillian Tran", "Mekhi Delacruz", "Mallory Perkins", "Sloane Marshall", "Osvaldo Le", "Krystal Shaw", "Annika Thomas", "Blaine Kelley", "Donna Joseph", "Steve Young", "Jaylen Juarez", "Izaiah Rogers", "Kylie Liu", "Jensen Fletcher", "Waylon Solomon", "Moriah Waller", "Raina Hill", "Miles Brock", "Sheldon Ortiz", "Cecilia Young", "Kirsten Yu", "Azaria Mcguire", "Krish Francis", "Sanai Chandler", "Shania Hooper", "Danica Jacobson", "Erica Huff", "August Ball", "Milo Hurst", "Evelin Moss", "Lea Hooper" };
            int ctr1 = 0;

            for (int i = 1; i <= 3; i++)
            {
                for (char c = 'V'; c < 'Z'; c++)
                {
                    b.BookPassenger(new Passenger("Jay", false), i + "" + c, BookingType.BusinessClass);
                }
            }

            for (int i = 1; i <= 7; i++)
            {
                for (char c = 'A'; c < 'H'; c++)
                {
                    b.BookPassenger(new Passenger(passengerNames[ctr1++], ctr1 % 14 == 3), i + "" + c, BookingType.Economy);
                }
            }

            b.BookPassenger(new Passenger("Karen", false), "1D", BookingType.Economy);
            b.BookPassenger(new Passenger("Mark", true), "1G", BookingType.Economy);
            b.BookPassenger(new Passenger("Devon", false), "1A", BookingType.Economy);
            Console.WriteLine(b);

            List<Passenger> pL = b.GetAllBusinessClassPassengers();
            Console.WriteLine("Business Class Passengers:");
            foreach (Passenger p in pL)
               Console.WriteLine(p);
            Console.WriteLine();

            /*List<Passenger> pM = b.GetAllEconomyPassengers();
            Console.WriteLine("Economy Passengers:");
            foreach (Passenger p in pM)
                Console.WriteLine(p);

            Airplane e = new Airplane("OOP123");
            Console.WriteLine(e);
          
            Airplane d = new Airplane("VIP143");
            d.setBusinessClassCapacity(12);
            d.SetEconomyCapacity(88);
            Console.WriteLine(d);*/
            Console.ReadLine(); 
        }
        
    }
}
