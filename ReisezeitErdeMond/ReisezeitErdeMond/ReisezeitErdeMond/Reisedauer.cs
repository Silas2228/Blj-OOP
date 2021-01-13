using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReisezeitErdeMond
{
    class Reisedauer
    {
        int mondentfernungerde = 384400; //Kilometer
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
