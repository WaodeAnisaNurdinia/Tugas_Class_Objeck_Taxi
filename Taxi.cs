using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TugasClassTaxi
{
    public class Taxi
    {
        //Properties
        public string DriverName { get; set; } 
        public Boolean OnDuty { get; set; }
        public int Numpassanger { get; set; }

        //Method
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", DriverName);
            if (OnDuty == true)
            {
                Console.WriteLine("On Duty : Yes");
            }
            else if (OnDuty == false)
            {
                Console.WriteLine("On Duty : No");
            }
            Console.WriteLine("Numpassanger : {0}", Numpassanger);
        }
        public void PickUpPassenger()
        {
            Console.WriteLine("{0} Sedang Menjemput Penumpang", DriverName);
        }
        public void DropOffPassanger()
        {
            Console.WriteLine("{0} Sedang Menjemput Penumpang", DriverName);
        }
    }
}
