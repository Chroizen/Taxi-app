using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class Program
    {
        // Membuat objeck taxi
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();

            // Pengesetan nilai properties
            taxi.DriverName = "Chroizen";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            // method pemanggilan
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}
