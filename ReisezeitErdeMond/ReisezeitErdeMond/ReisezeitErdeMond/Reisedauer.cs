using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReisezeitErdeMond
{
    class Reisedauer
    {
        double mondentfernungerde = 384400; //Meter
        double zeit;
        public double Zeit
        {
            get { return zeit; }
            set { zeit = value; }
        }
        public void BerechneDauer(double geschwindigkeit)
        {
            
            zeit = mondentfernungerde / geschwindigkeit;
        }


    }
}
