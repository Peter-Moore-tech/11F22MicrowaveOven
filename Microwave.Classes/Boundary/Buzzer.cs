using Microwave.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microwave.Classes.Boundary
{
    public class Buzzer : IBuzzer
    {
        public void BeepThreeTimes()
        {
            Console.WriteLine("Buzzer says: Beep, beep, beep");
        }
    }
}
