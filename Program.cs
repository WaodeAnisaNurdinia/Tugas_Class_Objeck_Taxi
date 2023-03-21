using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TugasClassTaxi
{
    class program
    {
        static void Main(string[] args)
        {
            // Membuat Objek taxi
            Taxi taxi = new Taxi();

            // Pengesetan nilai properties
            taxi.DriverName = "Jono";
            taxi.OnDuty = false;
            taxi.Numpassanger = 10;

            // Panggilan Method
            taxi.TaxiInfo();

            Console.WriteLine();

            taxi.PickUpPassenger();
            taxi.DropOffPassanger();

            Console.ReadKey();
        }
    }
}