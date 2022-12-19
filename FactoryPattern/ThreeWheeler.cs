using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class ThreeWheeler : IVehicle
    {
        public ThreeWheeler() 
        { 
        
        }

        public void Drive ()
        {
            Console.WriteLine("The Threewheeler is in park");
        }
    }
}
